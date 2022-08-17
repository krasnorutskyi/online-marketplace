using Marketplace.Application.Paging;
using Marketplace.Core.Entities;
using System.Linq.Expressions;

namespace Marketplace.Application.IRepositories;

public interface IGenericRepository<TEntity> where TEntity : EntityBase
{
    Task<TEntity> GetByIdAsync(int id);
    
    Task<TEntity> GetByIdAsync(int id, params Expression<Func<TEntity, object>>[] includeProperties);

    void Attach(params object[] obj);

    Task AddAsync(TEntity entity);
    
    Task UpdateAsync(TEntity entity);
    
    Task DeleteAsync(TEntity entity);

    Task<PagedList<TEntity>> GetPageAsync(PageParameters pageParameters);

    Task<PagedList<TEntity>> GetPageAsync(PageParameters pageParameters, params Expression<Func<TEntity, object>>[] includeProperties);
    
    Task<PagedList<TEntity>> GetPageAsync(PageParameters pageParameters, Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includeProperties);

    Task SaveChangesAsync();
}