using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RKE.DAL.Abstract
{
    public interface IGenericRepository<TEntity>
    {
        Task<TEntity> AddAsync(TEntity entity);

        Task UpdateAsync(TEntity entity);
        
        Task<TEntity> DeleteAsync(TEntity entity);

        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<IEnumerable<TEntity>> GetByAsync(Expression<Func<TEntity, bool>> predicate);
        Task<TEntity> GetByIdAsync(int id);
        Task<int> GetCountAsync();
        Task<int> GetCountAsync(Expression<Func<TEntity, bool>> predicate);

        Task<List<TEntity>> FetchAsync();
        Task<List<TEntity>> FetchByAsync(Expression<Func<TEntity, bool>> predicate);
        Task<List<TEntity>> PaggingFetchAsync(int startIndex, int count);
        Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate);
        Task<List<TEntity>> PaggingFetchByAsync(Expression<Func<TEntity, bool>> predicate, int startIndex, int count);

        Task SaveAsync();
        Task<TEntity> FindAsync(Expression<Func<TEntity, bool>> match);
        Task<int> AddOrUpdates(TEntity entity, Expression<Func<TEntity, bool>> predicate);
    }
}
