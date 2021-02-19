using BancassuranceLib.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BancassuranceLib.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly DbSet<T> _dbSet;
        private readonly BancassuranceContext _bancassuranceContext;

        public GenericRepository(BancassuranceContext bancassuranceContext)
        {
            _bancassuranceContext = bancassuranceContext;
            _dbSet = bancassuranceContext.Set<T>();
        }

        public async Task AddAsync(T item) => await _dbSet.AddAsync(item);

        public async Task<T> GetByIdAsync(object id) => await _dbSet.FindAsync(id);

        public async Task<T> GetSingleOrDefaultAsync(Expression<Func<T, bool>> filter)
            => await _dbSet.SingleOrDefaultAsync(filter);

        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = "")
        {
            IQueryable<T> query = _dbSet;

            if (filter != null)
                query = query.Where(filter);

            if (!string.IsNullOrEmpty(includeProperties))
            {
                var properties = includeProperties.Split(new char[] { ',', ';' });

                foreach (var property in properties)
                    query = query.Include(property);
            }

            if (orderBy != null)
                return await orderBy(query).ToListAsync();
            else
                return await query.ToListAsync();
        }

        public async Task DeleteAsync(object id) => await DeleteAsync(await GetByIdAsync(id));

        public async Task DeleteAsync(T item, bool attach = true)
        {
            await Task.Run(() =>
            {
                if (attach)
                    if (_bancassuranceContext.Entry(item).State == EntityState.Detached)
                        _dbSet.Attach(item);
                
                _dbSet.Remove(item);
            });
        }

        public async Task UpdateAsync(T item)
        {
            await Task.Run(() =>
            {
                if (_bancassuranceContext.Entry(item).State == EntityState.Detached)
                {
                    _dbSet.Attach(item);
                }

                _bancassuranceContext.Entry(item).State = EntityState.Modified;
            });
        }
    }
}
