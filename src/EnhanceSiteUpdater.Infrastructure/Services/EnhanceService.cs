using Enhance.Client;
using Enhance.Client.Models;
using EnhanceSiteUpdater.Core.Entities;
using EnhanceSiteUpdater.Infrastructure.EntityHelpers;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace EnhanceSiteUpdater.Infrastructure.Services;

public interface IEnhanceService
{
    Task<List<UpdaterWebsite>> GetWebsites(ApplicationUser user);
}

public class EnhanceService : IEnhanceService
{
    private IHttpClientFactory _httpFactory;

    public EnhanceService(IHttpClientFactory httpFactory)
    {
        _httpFactory = httpFactory;
    }

    public async Task<List<UpdaterWebsite>> GetWebsites(ApplicationUser user)
    {
        HttpClient httpClient = _httpFactory.CreateClient("client");
        EnhanceClient client = BuildClient(user.ControlPanelUrl, user.BearerApiKey, httpClient);

        WebsitesListing websites = await client.Orgs[user.OrganizationId.Value].Websites.GetAsync(website => website.QueryParameters.RecursionAsRecursion = Recursion.Infinite);

        return websites?.Items?.ConvertAll(EnhanceToCore.EnhanceWebsite) ?? [];
    }
    
    public static EnhanceClient BuildClient(Uri baseurl, string apiKey, HttpClient httpClient) {
        httpClient.BaseAddress = baseurl;
        
        IAuthenticationProvider authenticationProvider = new ApiKeyAuthenticationProvider(apiKey, "Authorization", ApiKeyAuthenticationProvider.KeyLocation.Header);
        IRequestAdapter requestAdapter = new HttpClientRequestAdapter(authenticationProvider, httpClient: httpClient);
        
        return new EnhanceClient(requestAdapter);
    }
}