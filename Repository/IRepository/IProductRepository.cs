using FoodCourtBlazor.Data;

namespace FoodCourtBlazor.Repository.IRepository;

public interface IProductRepository : IBaseRepository<Product>
{
    // public Task<Product> Create(Category category);
    // public Task<Product> Update(Category category);
    // public Task<bool> Delete(Guid categoryId);
    // public Task<Product> Get(Guid categoryId);
    // public Task<IEnumerable<Product>> GetAll();
}