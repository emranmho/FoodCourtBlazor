using FoodCourtBlazor.Data;

namespace FoodCourtBlazor.Services.IService;

public interface ICategoryService
{
    Task<IEnumerable<Category>> GetAllCategories();
    Task<Category> GetCategory(Guid categoryId);
    Task<bool> DeleteCategory(Guid categoryId);
    Task<Category> CreateCategory(Category category);
    Task<Category> UpdateCategory(Category category);
}