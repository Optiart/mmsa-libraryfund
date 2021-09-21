using Data.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Data
{
    public class LibrarianRepository : Repository<Librarian, uint>
    {
        protected override Librarian GetEntityWithKeyOnly(uint key) => new() { UserId = key };

        protected override Func<Librarian, bool> GetKeyPredicate(uint key) => librarian => librarian.UserId == key;
    }
}
