using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using WebsiteMaintainer.Core.Entities;

namespace WebsiteMaintainer.Core.Repository;

public interface IWebsiteRepository
{
    Task AddAsync(Website website);
    Task AddOrUpdateAsync(Website website);
    Task<Website?> GetAsync(string domain);
    Task<bool> ExistsAsync(Website website);
    Task DeleteAsync(Website website);
    Task DeleteRangeAsync(IEnumerable<Website> websites);
    Task<IEnumerable<Website>> GetAllAsync();
}