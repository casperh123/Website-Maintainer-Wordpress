using WebsiteMaintainer.Core.Entities;
using WebsiteMaintainer.Core.Repository;
using Microsoft.EntityFrameworkCore;
using WebsiteMaintainer.Infrastructure.Data;

namespace WebsiteMaintainer.Infrastructure.Repository;

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

    public async Task<bool> Exists(UpdaterWebsite website)
    {
        return await context.Websites.ContainsAsync(website);
    }

    public async Task Delete(UpdaterWebsite website)
    {
        context.Remove(website);
        await context.SaveChangesAsync();
    }

    public async Task<List<UpdaterWebsite>> GetAllAsync()
    {
        return await context.Websites.ToListAsync();
    }
}