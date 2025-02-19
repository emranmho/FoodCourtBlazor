using System.Linq.Expressions;
using FoodCourtBlazor.Components;
using FoodCourtBlazor.Data;
using FoodCourtBlazor.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace FoodCourtBlazor.Repository;

public class BaseRepository<T> : IBaseRepository<T> where T : class
{
    private readonly DbSet<T> _dbSet;
    private readonly ApplicationDbContext _db;
    public BaseRepository(ApplicationDbContext db)
    {
        _db = db;
        _dbSet = db.Set<T>();
    }
    
    public async Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>>? filter = null, string? includeProperties = null, bool tracked = false)
    {
        IQueryable<T> query;
        
        if (tracked)
        {
            query = _dbSet;
        }
        else
        {
            query = _dbSet.AsNoTracking();
        }
        
        if (filter != null)
        {
            query = query.Where(filter);
        }
        
        if (!string.IsNullOrEmpty(includeProperties))
        {
            foreach (var includeProp in includeProperties
                         .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProp.Trim());
            }
        }
        return await query.ToListAsync();
    }

    public async Task<T> GetAsync(Expression<Func<T, bool>> filter, string? includeProperties = null, bool tracked = false)
    {
        IQueryable<T> query;
        
        if (tracked)
        {
            query = _dbSet;
        }
        else
        {
            query=_dbSet.AsNoTracking();
        }
        if (filter != null)
        {
            query = query.Where(filter);
        }
        if (!string.IsNullOrEmpty(includeProperties))
        {
            //Villa,VillaNumber -- case sensitive
            foreach (var includeProp in includeProperties
                         .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProp.Trim());
            }
        }
        return await query.FirstOrDefaultAsync();
    }

    public async Task<T> Create(T entity)
    {
        await _dbSet.AddAsync(entity);
        return entity;
    }

    public T Update(T entity)
    {
        _dbSet.Update(entity);
        return entity;
    }

    public async Task<bool> Any(Expression<Func<T, bool>> filter)
    {
        return await _dbSet.AnyAsync(filter);
    }

    public async Task Remove(T entity)
    {
        _dbSet.Remove(entity);
        await _db.SaveChangesAsync();
    }

    public async Task RemoveRange(IList<T> entity)
    {
        _dbSet.RemoveRange(entity);
        await _db.SaveChangesAsync();
    }
}