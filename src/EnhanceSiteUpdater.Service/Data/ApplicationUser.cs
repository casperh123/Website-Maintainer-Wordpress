using Microsoft.AspNetCore.Identity;

namespace EnhanceSiteUpdater.Service.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    public ApplicationUser(string userName, Uri controlPanelUrl, Guid organizationId, string apiKey) : base(userName)
    {
        ControlPanelUrl = controlPanelUrl;
        OrganizationId = organizationId;
        ApiKey = apiKey;
    }

    public ApplicationUser()
    {
        
    }

    public Uri? ControlPanelUrl { get; set; }
    public Guid? OrganizationId { get; set; }
    public string? ApiKey { get; set; }
}