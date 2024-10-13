using Microsoft.EntityFrameworkCore;

namespace EnhanceSiteUpdater.Core.Entities;

public class UpdaterWebsite
{
    public string Domain { get; set; }
    public Kind Kind { get; set; }
    public MaintenanceType MaintenanceType { get; set; }
}