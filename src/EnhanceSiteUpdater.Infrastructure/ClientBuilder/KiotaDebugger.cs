using System.Net.Http.Headers;

public class KiotaDebugger : DelegatingHandler
{
    protected override async Task<HttpResponseMessage> SendAsync(
        HttpRequestMessage request, CancellationToken cancellationToken)
    {
        HttpRequestHeaders headers = request.Headers;
        HttpResponseMessage response = await base.SendAsync(request, cancellationToken);
        
        string responseMessage = await response.Content.ReadAsStringAsync(cancellationToken);
        
        return  response;
    }
}