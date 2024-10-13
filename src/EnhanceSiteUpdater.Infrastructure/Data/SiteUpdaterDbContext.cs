using EnhanceSiteUpdater.Core.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EnhanceSiteUpdater.Infrastructure.Data;

public class SiteUpdaterDbContext : IdentityDbContext<ApplicationUser>
{
    public DbSet<ApplicationUser> Users { get; set; }
    public DbSet<UpdaterWebsite?> Websites { get; set; }

    public SiteUpdaterDbContext(DbContextOptions<SiteUpdaterDbContext> options) : base(options)
    {
    }
}