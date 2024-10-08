using EnhanceSiteUpdater.Core.Entities;
using EnhanceSiteUpdater.Core.Repository;
using EnhanceSiteUpdater.Service.Data;
using Microsoft.EntityFrameworkCore;

namespace EnhanceSiteUpdater.Service.Repository;

public class UserRepository(SiteUpdaterDbContext context) : BaseRepository(context), IUserRepository
{
    public async Task UpdateUser(ApplicationUser user)
    {
        Db.Users.Update(user);
        await Db.SaveChangesAsync();
    }
}