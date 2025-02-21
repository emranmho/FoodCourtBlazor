using FoodCourtBlazor.Components.Account;
using FoodCourtBlazor.Data;
using FoodCourtBlazor.Services.IService;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;

namespace FoodCourtBlazor.Services;

public class AuthService : IAuthService
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly AuthenticationStateProvider _authenticationStateProvider;

    public AuthService(UserManager<ApplicationUser> userManager, AuthenticationStateProvider authenticationStateProvider)
    {
        _userManager = userManager;
        _authenticationStateProvider = authenticationStateProvider;
    }
    
    
    public async Task<bool> IsUserAuthenticated()
    {
        var authState = await _authenticationStateProvider.GetAuthenticationStateAsync();
        return authState.User.Identity is not null && authState.User.Identity.IsAuthenticated;
    }
    
    public async Task<ApplicationUser?> GetCurrentUserAsync()
    {
        var authState = await _authenticationStateProvider.GetAuthenticationStateAsync();
        var user = authState.User;

        if (user.Identity is not null && user.Identity.IsAuthenticated)
        {
            return await _userManager.GetUserAsync(user);
        }

        return null;
    }
    
    public async Task<string?> GetUserIdAsync()
    {
        var user = await GetCurrentUserAsync();
        return user?.Id;
    }
    
    public async Task<string?> GetUserNameAsync()
    {
        var user = await GetCurrentUserAsync();
        return user?.UserName;
    }
}