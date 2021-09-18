using Data.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Data
{
    public class LibraryRepository : Repository<Library, uint>, ILibraryRepository
    {
        public LibraryRepository(LibraryFundDbContext context) : base(context)
        {
        }

        protected override Library GetEntityWithKeyOnly(uint key) => new() { Id = key };

        protected override Func<Library, bool> GetKeyPredicate(uint key) => library => library.Id == key;

        public async Task<ICollection<Library>> GetWithRoomsAndLibrarians(CancellationToken cancellationToken)
        {
            return await DbContext.Libraries
                .Include(l => l.StorageRooms)
                .Include(l => l.ReadingRooms)
                    .ThenInclude(r => r.Librarians)
                    .ThenInclude(l => l.User)
                .ToListAsync();
        }
    }
}
