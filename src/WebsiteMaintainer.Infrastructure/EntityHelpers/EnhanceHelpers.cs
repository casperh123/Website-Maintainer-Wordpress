using Enhance.Client.Models;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using WebsiteMaintainer.Core.Entities;
using Website = WebsiteMaintainer.Core.Entities.Website;

namespace WebsiteMaintainer.Infrastructure.EntityHelpers;

public class EnhanceHelpers
{
    public static Website EnhanceWebsite(Enhance.Client.Models.Website website)
    {
        return new Website(
            website.Domain.Domain,
            EnhanceKind(website.Kind ?? WebsiteKind.Normal),
            MaintenanceType.None,
            website.Id ?? Guid.Empty,
            Provider.Enhance
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