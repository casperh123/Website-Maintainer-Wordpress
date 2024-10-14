using Microsoft.EntityFrameworkCore;

namespace EnhanceSiteUpdater.Core.Entities;

public class UpdaterWebsite
{
    public string Domain { get; set; }
    public Kind Kind { get; set; }
    public MaintenanceType MaintenanceType { get; set; }

    public UpdaterWebsite(string domain, Kind kind, MaintenanceType maintenanceType)
    {
        Domain = domain;
        Kind = kind;
        MaintenanceType = maintenanceType;
    }

    public override bool Equals(object? obj)
    {
        if (obj == null || obj.GetType() != GetType())
            return false;

        UpdaterWebsite? other = obj as UpdaterWebsite;

        return string.Equals(Domain, other?.Domain, StringComparison.OrdinalIgnoreCase);
    }

    public override int GetHashCode()
    {
        return Domain.ToLowerInvariant().GetHashCode();
    }
}