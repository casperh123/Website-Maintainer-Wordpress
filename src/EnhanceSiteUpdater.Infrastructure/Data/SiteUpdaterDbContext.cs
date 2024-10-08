using EnhanceSiteUpdater.Core.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EnhanceSiteUpdater.Service.Data;

public class SiteUpdaterDbContext(DbContextOptions<SiteUpdaterDbContext> options)
    : IdentityDbContext<ApplicationUser>(options)
{
    public DbSet<ApplicationUser> Users { get; set; }
}