using Microsoft.EntityFrameworkCore;

namespace WebsiteMaintainer.Core.Entities;

public class Website : IEquatable<Website>
{
    public string Domain { get; set; }
    public Kind Kind { get; set; }
    public MaintenanceType MaintenanceType { get; set; }
    public Guid OriginId { get; set; }
    public Provider Provider { get; set; }
    
    public Website(string domain, Kind kind, MaintenanceType maintenanceType)
    {
        Domain = domain;
        Kind = kind;
        MaintenanceType = maintenanceType;
    }

    public bool IsAdded => MaintenanceType switch
    {
        MaintenanceType.None => false,
        _ => true
    };

    public List<MaintenanceType> AddedMaintenanceTypes => [MaintenanceType.Regular, MaintenanceType.Care];

    public bool Equals(Website? other)
    {
        if (other == null)
            return false;

        return string.Equals(Domain, other.Domain, StringComparison.OrdinalIgnoreCase);
    }

    public override bool Equals(object? obj)
    {
        if (obj == null || obj.GetType() != GetType())
            return false;

        Website? other = obj as Website;

        return Equals(other);
    }

    public override int GetHashCode()
    {
        return Domain != null
            ? StringComparer.OrdinalIgnoreCase.GetHashCode(Domain)
            : 0;
    }
}