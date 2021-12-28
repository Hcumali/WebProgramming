using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace WebProgramming.Models
{
    public abstract class EfEntityRepositoryBase<TEntity> : IEntityRepository<TEntity>, IDisposable
        where TEntity : class, IEntity, new()
    {
        private readonly DbContext _dbContext;
        public EfEntityRepositoryBase(DbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public virtual IQueryable<TEntity> Entity
        {

            get
            {

                return _dbContext.Set<TEntity>().AsQueryable();

            }
        }


        public async virtual Task<TEntity> AddAsync(TEntity entity)
        {

            _dbContext.Add(entity);
            await _dbContext.SaveChangesAsync();

            return await Task.FromResult(entity);
        }

        public async virtual Task<TEntity> DeleteAsync(TEntity entity)
        {

            var deleteEntity = _dbContext.Entry(entity);
            deleteEntity.State = EntityState.Deleted;
            await _dbContext.SaveChangesAsync();

            return await Task.FromResult(entity);
        }

        public async virtual Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> filter)
        {

            return await Task.FromResult(_dbContext.Set<TEntity>().FirstOrDefault(filter));

        }

        public virtual async Task<List<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> filter = null)
        {

            var setEntity = _dbContext.Set<TEntity>();
            return await (filter == null ? setEntity.ToListAsync() : setEntity.Where(filter).ToListAsync());

        }

        public async virtual Task<TEntity> UpdateAsync(TEntity entity)
        {

            var updatedEntity = _dbContext.Entry(entity);
            updatedEntity.State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();

            return await Task.FromResult(entity);
        }

        public virtual void Dispose()
        {
            _dbContext.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
