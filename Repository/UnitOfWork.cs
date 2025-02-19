using FoodCourtBlazor.Data;
using FoodCourtBlazor.Repository.IRepository;

namespace FoodCourtBlazor.Repository;

public class UnitOfWork : IUnitOfWork
{
    private readonly ApplicationDbContext _db;
    
    
    public ICategoryRepository Category { get; private set; }
    public IProductRepository Product { get; private set; }
    public IShoppingCartRepository ShoppingCart { get; private set; }

    public UnitOfWork(ApplicationDbContext db)
    {
        _db = db;
        Category = new CategoryRepository(_db);
        Product = new ProductRepository(_db);
        ShoppingCart = new ShoppingCartRepository(_db);
    }
    
    public async Task<bool> SaveAsync()
    {
        return await _db.SaveChangesAsync() > 0;
    }
}