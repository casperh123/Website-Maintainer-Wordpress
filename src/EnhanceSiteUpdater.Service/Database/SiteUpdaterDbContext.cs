using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EnhanceSiteUpdater.Service.Database;

public class SiteUpdaterDbContext : IdentityDbContext<IdentityUser>
{
    public string DbPath { get; }

    public SiteUpdaterDbContext(DbContextOptions<SiteUpdaterDbContext> options) : base(options)
    {
        Environment.SpecialFolder folder = Environment.SpecialFolder.LocalApplicationData;
        string path = Environment.GetFolderPath(folder);
        DbPath = Path.Join(path, "SiteUpdater.db");
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
}