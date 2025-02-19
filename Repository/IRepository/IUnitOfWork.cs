namespace FoodCourtBlazor.Repository.IRepository;

public interface IUnitOfWork
{
    ICategoryRepository Category { get; }
    IProductRepository Product { get; }
    IShoppingCartRepository ShoppingCart { get; }
    Task<bool> SaveAsync();
}