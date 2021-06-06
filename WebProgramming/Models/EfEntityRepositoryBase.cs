using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace WebProgramming.Models
{
    public abstract class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>, IDisposable 
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public virtual IQueryable<TEntity> Entity
        {

            get
            {
                using (TContext context = new TContext())
                {
                    return context.Set<TEntity>().AsQueryable();
                }
            }
        }


        public async virtual Task<TEntity> AddAsync(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                context.Add(entity);
                await context.SaveChangesAsync();
            }
            return await Task.FromResult(entity);
        }

        public async virtual Task<TEntity> DeleteAsync(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deleteEntity = context.Entry(entity);
                deleteEntity.State = EntityState.Deleted;
                await context.SaveChangesAsync();
            }
            return await Task.FromResult(entity);
        }

        public async virtual Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return await Task.FromResult(context.Set<TEntity>().FirstOrDefault(filter));
            }
        }

        public virtual async Task<List<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                var setEntity = context.Set<TEntity>();
                return await (filter == null ? setEntity.ToListAsync() : setEntity.Where(filter).ToListAsync());
            }
        }

        public async virtual Task<TEntity> UpdateAsync(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                await context.SaveChangesAsync();
            }
            return await Task.FromResult(entity);
        }

        public virtual void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
