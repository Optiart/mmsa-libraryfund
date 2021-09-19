using Data.Dto;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Data
{
    public interface IFundRepository
    {
        Task<ICollection<Fund>> GetFunds(CancellationToken cancellationToken);

        Task<ICollection<Fund>> GetFunds(Func<Fund, bool>[] predicates, CancellationToken cancellationToken);

        Task<ICollection<Book>> GetBooks(CancellationToken cancellationToken);

        Task<ICollection<Book>> GetBooks(Func<Book, bool>[] predicates, CancellationToken cancellationToken);

        Task<ICollection<PeriodicalLiterature>> GetPeriodicLiterature(CancellationToken cancellationToken);

        Task<ICollection<PeriodicalLiterature>> GetPeriodicLiterature(Func<PeriodicalLiterature, bool>[] predicates, CancellationToken cancellationToken);

        Task<ICollection<FundOther>> GetOtherFunds(CancellationToken cancellationToken);

        Task<ICollection<FundOther>> GetOtherFunds(Func<FundOther, bool>[] predicates, CancellationToken cancellationToken);
    }
}
