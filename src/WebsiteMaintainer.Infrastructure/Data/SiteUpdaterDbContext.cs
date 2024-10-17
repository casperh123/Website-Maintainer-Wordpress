using WebsiteMaintainer.Core.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WebsiteMaintainer.Infrastructure.Data;

public class SiteUpdaterDbContext : IdentityDbContext<ApplicationUser>
{
    public DbSet<ApplicationUser> Users { get; set; }
    public DbSet<Website> Websites { get; set; }

    public SiteUpdaterDbContext(DbContextOptions<SiteUpdaterDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<Website>().HasKey(website => website.Domain);
    }
}