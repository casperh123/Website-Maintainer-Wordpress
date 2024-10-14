using Microsoft.AspNetCore.Identity;

namespace EnhanceSiteUpdater.Core.Entities;

public class ApplicationUser : IdentityUser
{
    public ApplicationUser(string userName, Uri controlPanelUrl, Guid organizationId, string apiKey) : base(userName)
    {
        ControlPanelUrl = new Uri(controlPanelUrl, "/api/");
        OrganizationId = organizationId;
        ApiKey = apiKey;
    }

    public ApplicationUser()
    {
        
    }

    public Uri? ControlPanelUrl { get; set; }
    public Guid? OrganizationId { get; set; }
    public string? ApiKey { get; set; }
    
    public string BearerApiKey => $"Bearer {ApiKey}";
}