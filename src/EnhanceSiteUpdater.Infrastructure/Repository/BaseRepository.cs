using EnhanceSiteUpdater.Service.Data;

namespace EnhanceSiteUpdater.Service.Repository;

public class BaseRepository(SiteUpdaterDbContext context)
{
    protected SiteUpdaterDbContext Db => context;
}