using System.Linq.Expressions;

namespace FoodCourtBlazor.Repository.IRepository;

public interface IBaseRepository<T> where T : class
{
    Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>>? filter = null, string? includeProperties = null, bool tracked = false);
    Task<T> GetAsync(Expression<Func<T, bool>> filter, string? includeProperties = null, bool tracked = false);
    
    Task<T> Create(T entity);
    T Update(T entity);
    
    Task<bool> Any(Expression<Func<T, bool>> filter);
    Task Remove(T entity);
}