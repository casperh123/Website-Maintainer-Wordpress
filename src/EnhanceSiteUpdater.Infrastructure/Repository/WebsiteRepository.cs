using EnhanceSiteUpdater.Core.Entities;
using EnhanceSiteUpdater.Core.Repository;
using EnhanceSiteUpdater.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace EnhanceSiteUpdater.Infrastructure.Repository;

public class WebsiteRepository(SiteUpdaterDbContext context) : BaseRepository(context), IWebsiteRepository
{
    public async Task Add(UpdaterWebsite website)
    {
        context.Add(website);
        await context.SaveChangesAsync();
    }

    public async Task AddOrUpdate(UpdaterWebsite website)
    {
        if (await context.Websites.ContainsAsync(website))
        {
            context.Update(website);
        }
        else
        {
            context.Add(website);
        }
        
        await context.SaveChangesAsync();
    }

    public async Task<UpdaterWebsite?> Get(string domain)
    {
        return await context.Websites.FindAsync(domain);
    }
}