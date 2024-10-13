using System.ComponentModel.DataAnnotations;
using EnhanceSiteUpdater.Core.Entities;

namespace EnhanceSiteUpdater.Core.Repository;

public interface IWebsiteRepository
{
    Task Add(UpdaterWebsite website);
    Task AddOrUpdate(UpdaterWebsite website);
    Task<UpdaterWebsite?> Get(string domain);
}