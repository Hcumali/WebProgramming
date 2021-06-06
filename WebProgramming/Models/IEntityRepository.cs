using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace WebProgramming.Models
{
    public interface IEntityRepository<T> where T : class,IEntity,new()
    {
        IQueryable<T> Entity { get; }
        Task<T> AddAsync(T entity);
        Task<T> DeleteAsync(T entity);
        Task<T> GetAsync(Expression<Func<T,bool>> filter);
        Task<List<T>> GetListAsync(Expression<Func<T,bool>> filter = null);
        Task<T> UpdateAsync(T entity);

    }
}
