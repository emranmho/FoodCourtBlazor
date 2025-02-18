using FoodCourtBlazor.Data;
using FoodCourtBlazor.Repository.IRepository;

namespace FoodCourtBlazor.Repository;

public class ProductRepository : BaseRepository<Product>, IProductRepository
{
    private readonly ApplicationDbContext _db;
    
    public ProductRepository(ApplicationDbContext db) : base(db)
    {
        _db = db;
    }
}