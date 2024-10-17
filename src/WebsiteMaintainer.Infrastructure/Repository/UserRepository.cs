using WebsiteMaintainer.Core.Entities;
using WebsiteMaintainer.Core.Repository;
using WebsiteMaintainer.Infrastructure.Data;

namespace WebsiteMaintainer.Infrastructure.Repository;

public class UserRepository(SiteUpdaterDbContext context) : BaseRepository(context), IUserRepository
{
    public async Task UpdateUser(ApplicationUser user)
    {
        Db.Users.Update(user);
        await Db.SaveChangesAsync();
    }
}