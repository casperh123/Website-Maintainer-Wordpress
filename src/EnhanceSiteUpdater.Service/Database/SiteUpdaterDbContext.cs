using Microsoft.EntityFrameworkCore;

namespace EnhanceSiteUpdater.Service.Database;

public class SiteUpdaterDbContext : DbContext
{
    public string DbPath { get; }

    public SiteUpdaterDbContext()
    {
        Environment.SpecialFolder folder = Environment.SpecialFolder.LocalApplicationData;
        string path = Environment.GetFolderPath(folder);
        DbPath = Path.Join(path, "SiteUpdater.db");
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
}