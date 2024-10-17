namespace WebsiteMaintainer.Infrastructure.Authentication;

public record EnhanceAuthentication
{
    public Uri ControlPanelUrl { get; }
    public string OrganisationId { get; }
    public string ApiKey { get; }
    
    public EnhanceAuthentication(Uri controlPanelUrl)
    {
        ControlPanelUrl = controlPanelUrl;
    }
}