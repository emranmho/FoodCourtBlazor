using FoodCourtBlazor.Data;

namespace FoodCourtBlazor.Services.IService;

public interface IShoppingCartService
{
    Task<bool> ClearCartAsync(string userId);
    
    Task<IEnumerable<ShoppingCart>> GetAllAsync(string userId);
    Task<ShoppingCart> GetShoppingCart(Guid shoppingCartId);
    Task<bool> DeleteShoppingCart(Guid shoppingCartId);
    Task<ShoppingCart> CreateShoppingCart(ShoppingCart shoppingCart);
    Task<bool> CreateOrUpdateCart(string userId, Guid productId, int count);
}