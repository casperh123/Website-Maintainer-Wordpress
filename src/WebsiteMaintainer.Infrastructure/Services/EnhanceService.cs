using System.Net;
using Enhance.Client;
using Enhance.Client.Models;
using WebsiteMaintainer.Core.Entities;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using WebsiteMaintainer.Core.Exceptions;
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
    private readonly IHttpClientFactory _httpClientFactory;
    private const string HttpClientName = "client";

    public EnhanceService(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }
    
    public async Task<List<Website>> GetWebsites(ApplicationUser user)
    {
        ValidateUserCredentials(user);
        
        EnhanceClient client = BuildClient(user.ControlPanelUrl, user.BearerApiKey);
        Guid organizationId = user.OrganizationId.Value;
        WebsitesListing? websites = new WebsitesListing();

        try
        {
            websites = await client
                .Orgs[organizationId]
                .Websites.GetAsync(website =>
                {
                    website.QueryParameters.RecursionAsRecursion = Recursion.Infinite;
                    website.QueryParameters.KindAsWebsiteKind = WebsiteKind.Normal;
                });
        }
        catch (ApiException apiException)
        {
            ThrowProperException(apiException);
        }
        
        return websites.Items.ConvertAll(EnhanceHelpers.EnhanceWebsite) ?? [];
    }

    public async Task<List<Plugin>> GetPlugins(ApplicationUser user, Website website)
    {
        ValidateUserCredentials(user);
        EnhanceClient client = BuildClient(user.ControlPanelUrl, user.BearerApiKey);
        Guid appId = await GetWordPressId(client, user, website.OriginId);

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
        ValidateUserCredentials(user);
        EnhanceClient client = BuildClient(user.ControlPanelUrl, user.BearerApiKey);
        Guid wordPressId = await GetWordPressId(client, user, website.OriginId);

        await client.Orgs[user.OrganizationId.Value]
            .Websites[website.OriginId]
            .Apps[wordPressId]
            .Wordpress
            .Plugins[plugin.Name]
            .Version
            .PatchAsync();
    }

    private async Task<Guid> GetWordPressId(EnhanceClient client, ApplicationUser user, Guid websiteId)
    {
        Guid organizationId = user.OrganizationId.Value;
        
        WebsiteAppsFullListing? apps = await client.Orgs[organizationId]
            .Websites[websiteId]
            .Apps.GetAsync();
        
        return apps.Items[0].Id ?? new Guid();
    }

    private void ThrowProperException(ApiException exception)
    {
        if (exception.ResponseStatusCode is 403)
        {
            throw new InvalidUserCredentials("User does not have access to the requested resource");
        }
    }

    private void ValidateUserCredentials(ApplicationUser user)
    {
        List<string> validationErrors = [];

        if (user.ControlPanelUrl is null)
        {
            validationErrors.Add("Please provide a valid contolpanel Url");
        }

        if (user.OrganizationId is null)
        {
            validationErrors.Add("Please provide a valid organization Id");
        }

        if (user.ApiKey is null)
        {
            validationErrors.Add("Please provade a valid API key");
        }

        if (validationErrors.Any())
        {
            throw new InvalidUserCredentials(string.Join(Environment.NewLine, validationErrors));
        }
    }
    
    private EnhanceClient BuildClient(Uri baseurl, string apiKey)
    {
        HttpClient httpClient = _httpClientFactory.CreateClient(HttpClientName);
        
        httpClient.BaseAddress = baseurl;
        
        IAuthenticationProvider authenticationProvider = new ApiKeyAuthenticationProvider(apiKey, "Authorization", ApiKeyAuthenticationProvider.KeyLocation.Header);
        IRequestAdapter requestAdapter = new HttpClientRequestAdapter(authenticationProvider, httpClient: httpClient);
        
        return new EnhanceClient(requestAdapter);
    }
}