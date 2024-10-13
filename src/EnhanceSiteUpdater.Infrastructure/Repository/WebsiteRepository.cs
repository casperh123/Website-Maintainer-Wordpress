using EnhanceSiteUpdater.Core.Entities;
using EnhanceSiteUpdater.Core.Repository;
using EnhanceSiteUpdater.Infrastructure.Data;

namespace EnhanceSiteUpdater.Infrastructure.Repository;

public class WebsiteRepository(SiteUpdaterDbContext context) : BaseRepository(context), IWebsiteRepository
{
    public async Task AddWebsite(UpdaterWebsite website)
    {
        context.Add(website);
        await context.SaveChangesAsync();
    }

    public async Task<UpdaterWebsite?> GetWebsite(string domain)
    {
        return await context.Websites.FindAsync(domain);
    }
}