using FoodCourtBlazor.Data;
using FoodCourtBlazor.Repository.IRepository;

namespace FoodCourtBlazor.Repository;

public class ShoppingCartRepository : BaseRepository<ShoppingCart>, IShoppingCartRepository
{
    private readonly ApplicationDbContext _db;
    
    public ShoppingCartRepository(ApplicationDbContext db) : base(db)
    {
        _db = db;
    }
}