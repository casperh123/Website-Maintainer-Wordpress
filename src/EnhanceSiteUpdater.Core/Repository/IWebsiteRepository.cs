using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using EnhanceSiteUpdater.Core.Entities;

namespace EnhanceSiteUpdater.Core.Repository;

public interface IWebsiteRepository
{
    Task Add(UpdaterWebsite website);
    Task AddOrUpdate(UpdaterWebsite website);
    Task<UpdaterWebsite?> Get(string domain);
    Task<bool> Exists(UpdaterWebsite website);
    Task Delete(UpdaterWebsite website);
    Task<List<UpdaterWebsite>> GetAllAsync();
}