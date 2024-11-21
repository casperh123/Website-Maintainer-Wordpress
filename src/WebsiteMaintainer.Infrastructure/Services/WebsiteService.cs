using WebsiteMaintainer.Core.Entities;
using WebsiteMaintainer.Core.Repository;

namespace WebsiteMaintainer.Infrastructure.Services;

public interface IWebsiteService
{
    Task<List<Website>> GetWebsitesAsync();
    Task AddOrUpdateWebsiteAsync(Website website);
    Task<List<Website>> SynchronizeMaintainedWebsitesAsync(List<Website> websites);
    Task SaveWebsitesAsync(List<Website> websites);
}

public class WebsiteService : IWebsiteService
{
    private readonly IWebsiteRepository _websiteRepository;

    public WebsiteService(IWebsiteRepository websiteRepository)
    {
        _websiteRepository = websiteRepository;
    }

    public async Task<List<Website>> GetWebsitesAsync()
    {
        IEnumerable<Website> websites = await _websiteRepository.GetAllAsync();
        
        return websites.ToList();
    }

    public async Task AddOrUpdateWebsiteAsync(Website website)
    {
        await _websiteRepository.AddOrUpdateAsync(website);
    }

    public async Task<List<Website>> SynchronizeMaintainedWebsitesAsync(List<Website> websites)
    {
        List<Website> maintainedWebsites = websites
            .Where(website => website.MaintenanceType is not MaintenanceType.None)
            .ToList();

        List<Website> websitesToDelete = websites
            .Where(website => website.MaintenanceType is MaintenanceType.None)
            .ToList();

        if (websitesToDelete.Any())
        {
            await _websiteRepository.DeleteRangeAsync(websitesToDelete);
        }

        await SaveWebsitesAsync(maintainedWebsites);
    
        return maintainedWebsites;
    }

    public async Task SaveWebsitesAsync(List<Website> websites)
    {
        foreach (Website website in websites)
        {
            await _websiteRepository.AddOrUpdateAsync(website);
        }
    }

}