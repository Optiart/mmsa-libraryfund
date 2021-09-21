using Data.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Data
{
    public class LibrarySqlRepository : Repository<Library, uint>, ILibraryRepository
    {
        protected override Library GetEntityWithKeyOnly(uint key) => new() { Id = key };

        protected override Func<Library, bool> GetKeyPredicate(uint key) => library => library.Id == key;

        public async Task<ICollection<Library>> GetWithRoomsAndLibrarians(CancellationToken cancellationToken)
        {
            using var dbContext = new LibraryFundDbContext();
            return await dbContext.Libraries
                .Include(l => l.StorageRooms)
                .Include(l => l.ReadingRooms)
                    .ThenInclude(r => r.Librarians)
                    .ThenInclude(l => l.User)
                .AsNoTracking()
                .ToListAsync(cancellationToken);
        }

        public async Task<ICollection<Library>> GetWithRoomsAndLibrarians(Func<Library, bool>[] predicates, CancellationToken cancellationToken)
        {
            if (!predicates.Any())
            {
                throw new InvalidOperationException("predicates must be specified");
            }

            using var dbContext = new LibraryFundDbContext();
            var task = dbContext.Libraries
                .Include(l => l.StorageRooms)
                .Include(l => l.ReadingRooms)
                    .ThenInclude(r => r.Librarians)
                    .ThenInclude(l => l.User)
                    .AsNoTracking()
                    .AsAsyncEnumerable();

            IAsyncEnumerable<Library> filtered = default;
            foreach (var predicate in predicates)
            {
                filtered = task.Where(predicate);
            }

            return await filtered.ToListAsync(cancellationToken);
        }

        public async Task<ICollection<Library>> GetByFilter(Func<Library, bool> predicate, CancellationToken cancellationToken)
        {
            using var dbContext = new LibraryFundDbContext();
            return await dbContext.Libraries
                .AsNoTracking()
                .AsAsyncEnumerable()
                .Where(predicate)
                .ToListAsync(cancellationToken);
        }
    }
}
