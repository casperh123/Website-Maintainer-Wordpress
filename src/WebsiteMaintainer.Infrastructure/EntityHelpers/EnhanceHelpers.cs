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
            ToEntity(website.Kind ?? WebsiteKind.Normal),
            MaintenanceType.None,
            website.Id ?? Guid.Empty,
            Provider.Enhance
        );
    }

    public static PluginStatus ToEntity(WPPluginStatus? pluginStatus) => pluginStatus switch
    {
        WPPluginStatus.Active => PluginStatus.Active,
        WPPluginStatus.Inactive => PluginStatus.Inactive,
        WPPluginStatus.Unknown => PluginStatus.Unknown,
        _ => PluginStatus.Unknown
    };
    
    public static Kind ToEntity(WebsiteKind kind) => kind switch
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