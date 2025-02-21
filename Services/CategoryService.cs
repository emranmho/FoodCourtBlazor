using FoodCourtBlazor.Data;
using FoodCourtBlazor.Repository.IRepository;
using FoodCourtBlazor.Services.IService;

namespace FoodCourtBlazor.Services;

public class CategoryService(IUnitOfWork unitOfWork) : ICategoryService
{
    public async Task<IEnumerable<Category>> GetAllCategories()
    {
        var categories = await unitOfWork.Category.GetAllAsync();
        if (categories.Any())
        {
            return categories;
        }

        return new List<Category>();
    }

    public async Task<Category> GetCategory(Guid categoryId)
    {
        var obj = await unitOfWork.Category.GetAsync(ca=>ca.Id == categoryId);
        if (obj != null)
        {
            return obj;
        }

        return new Category();
    }

    public async Task<bool> DeleteCategory(Guid categoryId)
    {
        var obj = await unitOfWork.Category.GetAsync(ca=>ca.Id == categoryId, tracked:true);
        if (obj != null)
        {
            await unitOfWork.Category.Remove(obj);
            
        }

        return await unitOfWork.SaveAsync();
    }

    public async Task<Category> CreateCategory(Category category)
    {
        var obj = await unitOfWork.Category.Create(category);
        await unitOfWork.SaveAsync();
        return obj;
    }

    public async Task<Category> UpdateCategory(Category category)
    {
        var obj = await unitOfWork.Category.GetAsync(ca=>ca.Id == category.Id, tracked:true);
        if (obj != null)
        {
            obj.Name = category.Name;
            await unitOfWork.SaveAsync();
            return obj;
        }

        return category;
    }
}