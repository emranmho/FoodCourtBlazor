using FoodCourtBlazor.Data;
using FoodCourtBlazor.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace FoodCourtBlazor.Repository;

public class CategoryRepository : ICategoryRepository
{
    private readonly ApplicationDbContext _db;
    
    public CategoryRepository(ApplicationDbContext db)
    {
        _db = db;
    }
    
    public async Task<Category> Create(Category category)
    {
        await _db.Categories.AddAsync(category);
        await _db.SaveChangesAsync();
        return category;
    }

    public async Task<Category> Update(Category category)
    {
        var obj = await _db.Categories.FirstOrDefaultAsync(c => c.Id == category.Id);
        if (obj != null)
        {
            obj.Name = category.Name;
            _db.Categories.Update(obj);
            await _db.SaveChangesAsync();
            return obj;
        }
        return category;
    }

    public async Task<bool> Delete(Guid categoryId)
    {
        var obj = await _db.Categories.FirstOrDefaultAsync(c => c.Id == categoryId);
        if (obj != null)
        {
            _db.Categories.Remove(obj);
            await _db.SaveChangesAsync();
            return true;
        }
        return false;
    }

    public async Task<Category>? Get(Guid categoryId)
    {
        var category = await _db.Categories.FirstOrDefaultAsync(c => c.Id == categoryId);
        if(category == null)
        {
            return null;
        }
        return category;
    }

    public async Task<IEnumerable<Category>> GetAll()
    {
        return await _db.Categories.ToListAsync();
    }
}