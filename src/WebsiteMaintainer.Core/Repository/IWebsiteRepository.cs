using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using WebsiteMaintainer.Core.Entities;

namespace WebsiteMaintainer.Core.Repository;

public interface IWebsiteRepository
{
    Task Add(Website website);
    Task AddOrUpdate(Website website);
    Task<Website?> Get(string domain);
    Task<bool> Exists(Website website);
    Task Delete(Website website);
    Task<List<Website>> GetAllAsync();
}