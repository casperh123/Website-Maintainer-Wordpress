using Enhance.Client.Models;
using WebsiteMaintainer.Core.Entities;

namespace WebsiteMaintainer.Infrastructure.EntityHelpers;

public class EnhanceToCore
{
    public static UpdaterWebsite EnhanceWebsite(Enhance.Client.Models.Website website)
    {
        return new UpdaterWebsite(
            website.Domain.Domain,
            EnhanceKind(website.Kind ?? WebsiteKind.Normal),
            MaintenanceType.None
        );
    }
    
    public static Kind EnhanceKind(WebsiteKind kind) => kind switch
    {
        WebsiteKind.Normal => Kind.Normal,
        WebsiteKind.Roundcube => Kind.Roundcube,
        WebsiteKind.Staging => Kind.Staging,
        WebsiteKind.ControlPanel => Kind.ControlPanel,
        WebsiteKind.PhpMyAdmin => Kind.PhpMyAdmin,
        WebsiteKind.ServerHostname => Kind.ServerHostname,
        _ => Kind.Normal
    };
}