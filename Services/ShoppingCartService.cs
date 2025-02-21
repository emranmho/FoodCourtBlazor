using FoodCourtBlazor.Data;
using FoodCourtBlazor.Repository.IRepository;
using FoodCourtBlazor.Services.IService;
using Microsoft.AspNetCore.Components.Forms;

namespace FoodCourtBlazor.Services;

public class ShoppingCartService(IUnitOfWork unitOfWork) : IShoppingCartService
{
    public async Task<bool> ClearCartAsync(string userId)
    {
        var items = await unitOfWork.ShoppingCart.GetAllAsync(x => x.UserId == userId);
        if (items.Any())
        {
            await unitOfWork.ShoppingCart.RemoveRange(items.ToList());
            await unitOfWork.SaveAsync();
            return true;
        }

        return false;
    }

    public async Task<IEnumerable<ShoppingCart>> GetAllAsync(string userId)
    {
        var obj = await unitOfWork.ShoppingCart.GetAllAsync(x => x.UserId == userId, includeProperties:"Product");
        if (obj.Any())
        {
            return obj;
        }

        return new List<ShoppingCart>();
    }
    
    public Task<ShoppingCart> GetShoppingCart(Guid shoppingCartId)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> DeleteShoppingCart(Guid shoppingCartId)
    {
        var items = await unitOfWork.ShoppingCart.GetAsync(x => x.Id == shoppingCartId, tracked:true);
        if (items is not null)
        {
            await unitOfWork.ShoppingCart.Remove(items);
        }

        return await unitOfWork.SaveAsync();
    }

    public async Task<ShoppingCart> CreateShoppingCart(ShoppingCart shoppingCart)
    {
        var obj = await unitOfWork.ShoppingCart.Create(shoppingCart);
        await unitOfWork.SaveAsync();
        return obj;
    }

    public async Task<bool> CreateOrUpdateCart(string userId, Guid productId, int count)
    {
        if (string.IsNullOrWhiteSpace(userId) || productId == Guid.Empty)
        {
            return false;
        }
        
        var cart = await unitOfWork.ShoppingCart.GetAsync(x => x.UserId == userId && x.ProductId == productId, tracked:true);
        if (cart == null)
        {
            cart = new ShoppingCart
            {
                UserId = userId,
                ProductId = productId,
                Count = count
            };
            await unitOfWork.ShoppingCart.Create(cart);
        }
        else
        {
            cart.Count += count;
            if(cart.Count <= 0)
            {
                await unitOfWork.ShoppingCart.Remove(cart);
            }
        }

        return await unitOfWork.SaveAsync();
    }
}