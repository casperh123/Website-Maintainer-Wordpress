using Enhance.Client;
using Enhance.Client.Models;
using WebsiteMaintainer.Core.Entities;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using WebsiteMaintainer.Infrastructure.EntityHelpers;
using Website = WebsiteMaintainer.Core.Entities.Website;

namespace WebsiteMaintainer.Infrastructure.Services;

public interface IEnhanceService
{
    Task<List<Website>> GetWebsites(ApplicationUser user);
    Task<List<Plugin>> GetPlugins(ApplicationUser user, Website website);
    Task UpdatePlugin(ApplicationUser user, Website website, Plugin plugin);
}

public class EnhanceService : IEnhanceService
{
    private HttpClient _httpClient;

    public EnhanceService(IHttpClientFactory httpFactory)
    {
        _httpClient = httpFactory.CreateClient("client");
    }

    public async Task<List<Website>> GetWebsites(ApplicationUser user)
    {
        EnhanceClient client = BuildClient(user.ControlPanelUrl, user.BearerApiKey);

        WebsitesListing websites = await client
            .Orgs[user.OrganizationId.Value]
            .Websites.GetAsync(website =>
            {
                website.QueryParameters.RecursionAsRecursion = Recursion.Infinite;
                website.QueryParameters.KindAsWebsiteKind = WebsiteKind.Normal;
            });
        
        return websites?.Items?.ConvertAll(EnhanceHelpers.EnhanceWebsite) ?? [];
    }

    public async Task<List<Plugin>> GetPlugins(ApplicationUser user, Website website)
    {
        EnhanceClient client = BuildClient(user.ControlPanelUrl, user.BearerApiKey);

        WebsiteAppsFullListing apps = await client.Orgs[user.OrganizationId.Value]
            .Websites[website.OriginId]
            .Apps.GetAsync();
        
        Guid appId = apps.Items[0].Id ?? new Guid();

        WpPluginsFullListing pluginListing = await client.Orgs[user.OrganizationId.Value]
            .Websites[website.OriginId]
            .Apps[appId]
            .Wordpress
            .Plugins
            .GetAsync() ?? new WpPluginsFullListing();
        
        
        List<Plugin> plugins = pluginListing.Items?.Select(plugin => new Plugin(
            plugin.Name ?? "N/A",
            plugin.Uri ?? "N/A",
            plugin.Version ?? "N/A",
            plugin.Update.HasValue && plugin.Update.Value == WPPluginUpdateAvailable.Available,
            EnhanceHelpers.ToEntity(plugin.Status)
        )).ToList() ?? [];    

        return plugins;
    }

    public async Task UpdatePlugin(ApplicationUser user, Website website, Plugin plugin)
    {
        HttpClient httpClient = _httpFactory.CreateClient("client");
        EnhanceClient client = BuildClient(user.ControlPanelUrl, user.BearerApiKey, httpClient);    
        
        WebsiteAppsFullListing apps = await client.Orgs[user.OrganizationId.Value]
            .Websites[website.OriginId]
            .Apps.GetAsync();
        
        Guid appId = apps.Items[0].Id ?? new Guid();

        await client.Orgs[user.OrganizationId.Value]
            .Websites[website.OriginId]
            .Apps[appId]
            .Wordpress
            .Plugins[plugin.Name]
            .Version
            .PatchAsync();
    }

    private EnhanceClient BuildClient(Uri baseurl, string apiKey) {
        _httpClient.BaseAddress = baseurl;
        
        IAuthenticationProvider authenticationProvider = new ApiKeyAuthenticationProvider(apiKey, "Authorization", ApiKeyAuthenticationProvider.KeyLocation.Header);
        IRequestAdapter requestAdapter = new HttpClientRequestAdapter(authenticationProvider, httpClient: _httpClient);
        
        return new EnhanceClient(requestAdapter);
    }
}