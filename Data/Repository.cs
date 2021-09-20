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
        protected readonly LibraryFundDbContext DbContext;
        protected abstract Func<TEntity, bool> GetKeyPredicate(TKey key );
        protected abstract TEntity GetEntityWithKeyOnly(TKey key);

        public Repository(LibraryFundDbContext context)
        {
            DbContext = context;
        }

        public async Task Add(TEntity entity, CancellationToken cancellationToken)
        {
            await DbContext.AddAsync(entity);
            await DbContext.SaveChangesAsync(cancellationToken);
        }

        public Task Delete(TKey key, CancellationToken cancellationToken)
        {
            var entity = GetEntityWithKeyOnly(key);
            DbContext.Remove(entity);
            return DbContext.SaveChangesAsync(cancellationToken);
        }

        public async Task<TEntity> Get(TKey key, CancellationToken cancellationToken)
        {
            var entity = await DbContext.Set<TEntity>().AsNoTracking().AsAsyncEnumerable().FirstOrDefaultAsync(GetKeyPredicate(key), cancellationToken);
            if (entity == null)
            {
                throw new EntityNotFoundException(typeof(TEntity).Name);
            }
            return entity;
        }

        public async Task<ICollection<TEntity>> GetAll(CancellationToken cancellationToken) =>
            await DbContext.Set<TEntity>().AsNoTracking().AsAsyncEnumerable().ToListAsync(cancellationToken);

        public Task Update(TEntity entity, CancellationToken cancellationToken)
        {
            DbContext.Entry(entity).State = EntityState.Detached;
            DbContext.Update(entity);
            return DbContext.SaveChangesAsync(cancellationToken);
        }
    }
}
