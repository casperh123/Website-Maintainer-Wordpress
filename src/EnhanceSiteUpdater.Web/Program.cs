using EnhanceSiteUpdater.Service;
using EnhanceSiteUpdater.Service.Database;
using EnhanceSiteUpdater.Web.Components;
using Microsoft.AspNetCore.Identity;
using Radzen;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddScoped<ThemeService>();
builder.Services.AddHttpClient();
builder.Services.AddDbContext<SiteUpdaterDbContext>();
builder.Services.AddScoped<UpdateService>();

builder.Services.AddAuthorization();
    
builder.Services.AddIdentityApiEndpoints<IdentityUser>()
    .AddEntityFrameworkStores<SiteUpdaterDbContext>();

WebApplication app = builder.Build();

app.MapIdentityApi<IdentityUser>();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();