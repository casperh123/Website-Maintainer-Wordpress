using EnhanceSiteUpdater.Infrastructure.Data;

namespace EnhanceSiteUpdater.Infrastructure;

public class UpdateService(SiteUpdaterDbContext dbContext, HttpClient httpClient)
{
    private SiteUpdaterDbContext DbContext = dbContext;
    private HttpClient HttpClient = new();
}