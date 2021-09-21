using Data.Exceptions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Data
{
    public abstract class Repository<TEntity, TKey> : IRepository<TEntity, TKey> where TEntity: class
    {
        protected abstract Func<TEntity, bool> GetKeyPredicate(TKey key );
        protected abstract TEntity GetEntityWithKeyOnly(TKey key);

        public async Task Add(TEntity entity, CancellationToken cancellationToken)
        {
            using var dbContext = new LibraryFundDbContext();
            dbContext.Add(entity);
            await dbContext.SaveChangesAsync(cancellationToken);
        }

        public async Task Delete(TKey key, CancellationToken cancellationToken)
        {
            using var dbContext = new LibraryFundDbContext();
            var entity = GetEntityWithKeyOnly(key);
            dbContext.Remove(entity);
            await dbContext.SaveChangesAsync(cancellationToken);
        }

        public async Task<TEntity> Get(TKey key, CancellationToken cancellationToken)
        {
            using var dbContext = new LibraryFundDbContext();
            var entity = await dbContext.Set<TEntity>().AsNoTracking().AsAsyncEnumerable().FirstOrDefaultAsync(GetKeyPredicate(key), cancellationToken);
            if (entity == null)
            {
                throw new EntityNotFoundException(typeof(TEntity).Name);
            }
            return entity;
        }

        public async Task<ICollection<TEntity>> GetAll(CancellationToken cancellationToken)
        {
            using var dbContext = new LibraryFundDbContext();
            return await dbContext.Set<TEntity>().AsNoTracking().AsAsyncEnumerable().ToListAsync(cancellationToken);
        }
            

        public async Task Update(TEntity entity, CancellationToken cancellationToken)
        {
            using var dbContext = new LibraryFundDbContext();
            dbContext.Set<TEntity>().Update(entity);
            await dbContext.SaveChangesAsync(cancellationToken);
        }
    }
}
