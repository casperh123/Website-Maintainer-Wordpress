

using System.Net;
using Enhance.Client.Models;
using EnhanceSiteUpdaer.Web.Components;
using EnhanceSiteUpdaer.Web.Components.Account;
using EnhanceSiteUpdater.Core.Entities;
using EnhanceSiteUpdater.Core.Repository;
using EnhanceSiteUpdater.Infrastructure.Data;
using EnhanceSiteUpdater.Infrastructure.Repository;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Radzen;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddScoped<ThemeService>();

builder.Services.AddCascadingAuthenticationState();
builder.Services.AddScoped<IdentityUserAccessor>();
builder.Services.AddScoped<IdentityRedirectManager>();
builder.Services.AddScoped<AuthenticationStateProvider, IdentityRevalidatingAuthenticationStateProvider>();

builder.Services.AddScoped<KiotaDebugger>();

builder.Services.AddHttpClient<HttpClient>("client", client =>
    {
        client.DefaultRequestVersion = HttpVersion.Version30;
        client.DefaultVersionPolicy = HttpVersionPolicy.RequestVersionOrLower;
        client.Timeout = TimeSpan.FromSeconds(15);
        client.DefaultRequestHeaders.ConnectionClose = false;
        client.DefaultRequestHeaders.AcceptEncoding.ParseAdd("gzip, deflate, br");
    })
    .AddHttpMessageHandler<KiotaDebugger>();

builder.Services.AddAuthentication(options =>
    {
        options.DefaultScheme = IdentityConstants.ApplicationScheme;
        options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
    })
    .AddIdentityCookies();

string connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ??
                          throw new InvalidOperationException("Connection string 'DefaultConnection' not found in appsettings.json.");
builder.Services.AddDbContext<SiteUpdaterDbContext>(options =>
    options.UseSqlite(connectionString));

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddIdentityCore<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<SiteUpdaterDbContext>()
    .AddSignInManager()
    .AddDefaultTokenProviders();

builder.Services.AddSingleton<IEmailSender<ApplicationUser>, IdentityNoOpEmailSender>();

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IWebsiteRepository, WebsiteRepository>();

WebApplication app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

using (IServiceScope scope = app.Services.CreateScope())
{
    IServiceProvider services = scope.ServiceProvider;
    SiteUpdaterDbContext context = services.GetRequiredService<SiteUpdaterDbContext>();

    try
    {
        context.Database.Migrate();
    }
    catch (Exception e)
    {
        Console.WriteLine(e);
    }
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

// Add additional endpoints required by the Identity /Account Razor components.
app.MapAdditionalIdentityEndpoints();

app.Run();