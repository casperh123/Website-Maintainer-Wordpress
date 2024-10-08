using EnhanceSiteUpdater.Infrastructure.Data;

namespace EnhanceSiteUpdater.Infrastructure.Repository;

public class BaseRepository(SiteUpdaterDbContext context)
{
    protected SiteUpdaterDbContext Db => context;
}