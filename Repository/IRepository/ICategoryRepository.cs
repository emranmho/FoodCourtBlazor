using FoodCourtBlazor.Data;

namespace FoodCourtBlazor.Repository.IRepository;

public interface ICategoryRepository
{
    public Task<Category> Create(Category category);
    public Task<Category> Update(Category category);
    public Task<bool> Delete(Guid categoryId);
    public Task<Category> Get(Guid categoryId);
    public Task<IEnumerable<Category>> GetAll();
}