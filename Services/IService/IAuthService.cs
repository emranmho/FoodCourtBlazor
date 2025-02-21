using FoodCourtBlazor.Data;

namespace FoodCourtBlazor.Services.IService;

public interface IAuthService
{
    Task<bool> IsUserAuthenticated();
    Task<ApplicationUser?> GetCurrentUserAsync();
    Task<string?> GetUserIdAsync();
    Task<string?> GetUserNameAsync();
}