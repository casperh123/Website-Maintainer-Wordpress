using EnhanceSiteUpdater.Service.Data;

namespace EnhanceSiteUpdater.Service;

public class UpdateService(SiteUpdaterDbContext dbContext, HttpClient httpClient)
{
    private SiteUpdaterDbContext DbContext = dbContext;
    private HttpClient HttpClient = new();
}