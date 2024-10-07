using EnhanceSiteUpdater.Service.Authentication;
using EnhanceSiteUpdater.Service.DbContext;
using Microsoft.EntityFrameworkCore;

namespace EnhanceSiteUpdater.Service;

public class UpdateService(SiteUpdaterDbContext dbContext, HttpClient httpClient, EnhanceAuthentication authentication)
{
    private SiteUpdaterDbContext DbContext = dbContext;
    private HttpClient HttpClient = new();
    private EnhanceAuthentication Authentication = authentication;
}