using EnhanceSiteUpdater.Service.Authentication;
using EnhanceSiteUpdater.Service.Database;

namespace EnhanceSiteUpdater.Service;

public class UpdateService(SiteUpdaterDbContext dbContext, HttpClient httpClient)
{
    private SiteUpdaterDbContext DbContext = dbContext;
    private HttpClient HttpClient = new();
}