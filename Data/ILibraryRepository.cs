using Data.Dto;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Data
{
    public interface ILibraryRepository : IRepository<Library, uint>
    {
        Task<ICollection<Library>> GetWithRoomsAndLibrarians(CancellationToken cancellationToken);

        Task<ICollection<Library>> GetWithRoomsAndLibrarians(Func<Library, bool>[] filters, CancellationToken cancellationToken);

        Task<ICollection<Library>> GetByFilter(Func<Library, bool> predicate, CancellationToken cancellationToken);
    }
}
