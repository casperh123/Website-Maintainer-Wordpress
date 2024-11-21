using WebsiteMaintainer.Infrastructure.Data;

namespace WebsiteMaintainer.Infrastructure.Repository;

public class BaseRepository(SiteUpdaterDbContext dbContext)
{
    protected SiteUpdaterDbContext Db => dbContext;
}