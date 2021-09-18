using Data.Dto;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Data
{
    public interface ILibraryRepository : IRepository<Library, uint>
    {
        Task<ICollection<Library>> GetWithRoomsAndLibrarians(CancellationToken cancellationToken);
    }
}
