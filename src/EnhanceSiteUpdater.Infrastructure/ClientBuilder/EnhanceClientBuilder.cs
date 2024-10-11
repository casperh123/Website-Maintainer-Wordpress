using Enhance.Client;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace EnhanceSiteUpdater.Infrastructure.ClientBuilder;

public class EnhanceClientBuilder
{
    public static EnhanceClient Build(Uri baseurl, string apiKey, HttpClient httpClient) {
        httpClient.BaseAddress = baseurl;
        
        IAuthenticationProvider authenticationProvider = new ApiKeyAuthenticationProvider(apiKey, "Authorization", ApiKeyAuthenticationProvider.KeyLocation.Header);
        IRequestAdapter requestAdapter = new HttpClientRequestAdapter(authenticationProvider, httpClient: httpClient);
        
        return new EnhanceClient(requestAdapter);
    }
}