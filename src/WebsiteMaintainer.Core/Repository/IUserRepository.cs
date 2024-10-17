using WebsiteMaintainer.Core.Entities;

namespace WebsiteMaintainer.Core.Repository;

public interface IUserRepository
{
    Task UpdateUser(ApplicationUser user);
}