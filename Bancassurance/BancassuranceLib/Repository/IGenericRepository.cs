using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BancassuranceLib.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        Task AddAsync(T item);
        Task DeleteAsync(object id);
        Task DeleteAsync(T item, bool attach = true);
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "");
        Task<T> GetByIdAsync(object id);
        Task<T> GetSingleOrDefaultAsync(Expression<Func<T, bool>> filter);
        Task UpdateAsync(T item);
    }
}