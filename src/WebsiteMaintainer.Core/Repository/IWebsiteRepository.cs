using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using WebsiteMaintainer.Core.Entities;

namespace WebsiteMaintainer.Core.Repository;

public interface IWebsiteRepository
{
    Task Add(UpdaterWebsite website);
    Task AddOrUpdate(UpdaterWebsite website);
    Task<UpdaterWebsite?> Get(string domain);
    Task<bool> Exists(UpdaterWebsite website);
    Task Delete(UpdaterWebsite website);
    Task<List<UpdaterWebsite>> GetAllAsync();
}