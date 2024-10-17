using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using WebsiteMaintainer.Core.Entities;

namespace WebsiteMaintainer.Web.Services;

public interface IUserService
{
    Task<ApplicationUser> GetCurrentUserAsync();
}

public class UserService : IUserService
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public UserService(UserManager<ApplicationUser> userManager, IHttpContextAccessor httpContextAccessor)
    {
        _userManager = userManager;
        _httpContextAccessor = httpContextAccessor;
    }

    public async Task<ApplicationUser> GetCurrentUserAsync()
    {
        string? userId = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
        return await _userManager.FindByIdAsync(userId);
    }
}