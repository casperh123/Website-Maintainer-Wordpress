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
}

public class EnhanceService : IEnhanceService
{
    private IHttpClientFactory _httpFactory;

    public EnhanceService(IHttpClientFactory httpFactory)
    {
        _httpFactory = httpFactory;
    }

    public async Task<List<Website>> GetWebsites(ApplicationUser user)
    {
        HttpClient httpClient = _httpFactory.CreateClient("client");
        EnhanceClient client = BuildClient(user.ControlPanelUrl, user.BearerApiKey, httpClient);

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
        HttpClient httpClient = _httpFactory.CreateClient("client");
        EnhanceClient client = BuildClient(user.ControlPanelUrl, user.BearerApiKey, httpClient);

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
            plugin.Update.HasValue && plugin.Update.Value == WPPluginUpdateAvailable.Available
        )).ToList() ?? [];    

        return plugins;
    }

    private static EnhanceClient BuildClient(Uri baseurl, string apiKey, HttpClient httpClient) {
        httpClient.BaseAddress = baseurl;
        
        IAuthenticationProvider authenticationProvider = new ApiKeyAuthenticationProvider(apiKey, "Authorization", ApiKeyAuthenticationProvider.KeyLocation.Header);
        IRequestAdapter requestAdapter = new HttpClientRequestAdapter(authenticationProvider, httpClient: httpClient);
        
        return new EnhanceClient(requestAdapter);
    }
}