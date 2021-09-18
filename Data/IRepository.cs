using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Data
{
    public interface IRepository<TEntity, TKey>
    {
        Task<ICollection<TEntity>> GetAll(CancellationToken cancellationToken);

        Task<TEntity> Get(TKey id, CancellationToken cancellationToken);

        Task Add(TEntity entity, CancellationToken cancellationToken);

        Task Delete(TKey id, CancellationToken cancellationToken);

        Task Update(TEntity entity, CancellationToken cancellationToken);
    }
}
