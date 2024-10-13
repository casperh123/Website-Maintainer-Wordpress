using System.ComponentModel.DataAnnotations;
using EnhanceSiteUpdater.Core.Entities;

namespace EnhanceSiteUpdater.Core.Repository;

public interface IWebsiteRepository
{
    Task AddWebsite(UpdaterWebsite website);
    Task<UpdaterWebsite?> GetWebsite(string domain);
}