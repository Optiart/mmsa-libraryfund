using Data.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Data
{
    public class FundSqlRepository : Repository<Fund, uint>, IFundRepository
    {
        protected override Fund GetEntityWithKeyOnly(uint key) => new() { Id = key };

        protected override Func<Fund, bool> GetKeyPredicate(uint key) => fund => fund.Id == key;

        public async Task<ICollection<Fund>> GetFunds(CancellationToken cancellationToken)
        {
            using var dbContext = new LibraryFundDbContext();
            return await dbContext.Funds
                .Include(f => f.AuthorToFunds)
                    .ThenInclude(a => a.Author)
                .Include(f => f.FundCopies)
                    .ThenInclude(f => f.FundUsages)
                .ToListAsync(cancellationToken);
        }

        public async Task<ICollection<Fund>> GetFunds(Func<Fund, bool>[] predicates, CancellationToken cancellationToken)
        {
            if (!predicates.Any())
            {
                throw new InvalidOperationException("predicates must be specified");
            }

            using var dbContext = new LibraryFundDbContext();
            var task = dbContext.Funds
                .Include(f => f.AuthorToFunds)
                    .ThenInclude(a => a.Author)
                .Include(f => f.FundCopies)
                    .ThenInclude(f => f.FundUsages)
                .AsAsyncEnumerable();

            var filtered = GetFiltered(task, predicates);
            return await filtered.ToListAsync(cancellationToken);
        }

        public async Task<ICollection<Book>> GetBooks(CancellationToken cancellationToken)
        {
            using var dbContext = new LibraryFundDbContext();
            return await dbContext.Books.AsAsyncEnumerable().ToListAsync(cancellationToken);
        }
            

        public async Task<ICollection<Book>> GetBooks(Func<Book, bool>[] predicates, CancellationToken cancellationToken)
        {
            using var dbContext = new LibraryFundDbContext();
            var task = dbContext.Books.AsAsyncEnumerable();
            var filtered = GetFiltered(task, predicates);
            return await filtered.ToListAsync(cancellationToken);
        }

        public async Task<ICollection<PeriodicalLiterature>> GetPeriodicLiterature(CancellationToken cancellationToken)
        {
            using var dbContext = new LibraryFundDbContext();
            return await dbContext.PeriodicalLiteratures.AsAsyncEnumerable().ToListAsync(cancellationToken);
        }

        public async Task<ICollection<PeriodicalLiterature>> GetPeriodicLiterature(Func<PeriodicalLiterature, bool>[] predicates, CancellationToken cancellationToken)
        {
            using var dbContext = new LibraryFundDbContext();
            var task = dbContext.PeriodicalLiteratures.AsAsyncEnumerable();
            var filtered = GetFiltered(task, predicates);
            return await filtered.ToListAsync(cancellationToken);
        }

        public async Task<ICollection<FundOther>> GetOtherFunds(CancellationToken cancellationToken)
        {
            using var dbContext = new LibraryFundDbContext();
            return await dbContext.FundOthers.AsAsyncEnumerable().ToListAsync(cancellationToken);
        }
            
        public async Task<ICollection<FundOther>> GetOtherFunds(Func<FundOther, bool>[] predicates, CancellationToken cancellationToken)
        {
            using var dbContext = new LibraryFundDbContext();
            var task = dbContext.FundOthers.AsAsyncEnumerable();
            var filtered = GetFiltered(task, predicates);
            return await filtered.ToListAsync(cancellationToken);
        }

        private IAsyncEnumerable<T> GetFiltered<T>(IAsyncEnumerable<T> task, Func<T, bool>[] predicates)
        {
            IAsyncEnumerable<T> filtered = task;
            foreach (var predicate in predicates)
            {
                filtered = filtered.Where(predicate);
            }
            return filtered;
        }
    }
}
