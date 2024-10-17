using WebsiteMaintainer.Infrastructure.Data;

namespace WebsiteMaintainer.Infrastructure.Repository;

public class BaseRepository(SiteUpdaterDbContext context)
{
    protected SiteUpdaterDbContext Db => context;
}