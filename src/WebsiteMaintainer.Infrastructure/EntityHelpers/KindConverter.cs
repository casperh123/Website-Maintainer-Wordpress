using Enhance.Client.Models;
using WebsiteMaintainer.Core.Entities;

namespace WebsiteMaintainer.Infrastructure.EntityHelpers;

public class KindConverter
{
    public static Kind FromEnhance(WebsiteKind kind) => kind switch
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