using WebsiteMaintainer.Core.Entities;
using WebsiteMaintainer.Core.Repository;
using Microsoft.EntityFrameworkCore;
using WebsiteMaintainer.Infrastructure.Data;

namespace WebsiteMaintainer.Infrastructure.Repository;

public class WebsiteRepository(SiteUpdaterDbContext dbContext) : BaseRepository(dbContext), IWebsiteRepository
{
    public async Task AddAsync(Website website)
    {
        Db.Add(website);
        await Db.SaveChangesAsync();
    }

    public async Task AddOrUpdateAsync(Website website)
    {
        if (await Db.Websites.ContainsAsync(website))
        {
            Db.Update(website);
        }
        else
        {
            Db.Add(website);
        }
        
        await Db.SaveChangesAsync();
    }

    public async Task<Website?> GetAsync(string domain)
    {
        return await Db.Websites.FindAsync(domain);
    }

    public async Task<bool> ExistsAsync(Website website)
    {
        return await Db.Websites.ContainsAsync(website);
    }

    public async Task DeleteAsync(Website website)
    {
        Db.Remove(website);
        await Db.SaveChangesAsync();
    }

    public async Task DeleteRangeAsync(IEnumerable<Website> websites)
    {
        foreach (Website website in websites)
        {
            Db.Remove(website);
        }
        
        await Db.SaveChangesAsync();
    }

    public async Task<IEnumerable<Website>> GetAllAsync()
    {
        return await Db.Websites.ToListAsync();
    }
}