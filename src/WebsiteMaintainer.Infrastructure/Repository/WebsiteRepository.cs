using WebsiteMaintainer.Core.Entities;
using WebsiteMaintainer.Core.Repository;
using Microsoft.EntityFrameworkCore;
using WebsiteMaintainer.Infrastructure.Data;

namespace WebsiteMaintainer.Infrastructure.Repository;

public class WebsiteRepository(SiteUpdaterDbContext context) : BaseRepository(context), IWebsiteRepository
{
    public async Task Add(Website website)
    {
        context.Add(website);
        await context.SaveChangesAsync();
    }

    public async Task AddOrUpdate(Website website)
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

    public async Task<Website?> Get(string domain)
    {
        return await context.Websites.FindAsync(domain);
    }

    public async Task<bool> Exists(Website website)
    {
        return await context.Websites.ContainsAsync(website);
    }

    public async Task Delete(Website website)
    {
        context.Remove(website);
        await context.SaveChangesAsync();
    }

    public async Task<List<Website>> GetAllAsync()
    {
        return await context.Websites.ToListAsync();
    }
}