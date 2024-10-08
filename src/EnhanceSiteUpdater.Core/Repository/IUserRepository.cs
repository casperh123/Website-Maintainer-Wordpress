using EnhanceSiteUpdater.Core.Entities;

namespace EnhanceSiteUpdater.Core.Repository;

public interface IUserRepository
{
    Task UpdateUser(ApplicationUser user);
}