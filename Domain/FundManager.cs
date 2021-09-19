using Data;
using Domain.Builders;
using Domain.Builders.Funds;
using Domain.Enum;
using Domain.Models;
using Domain.Models.Funds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Domain
{
    public class FundManager
    {
        private readonly IFundRepository _fundRepository;
        private readonly BookBuilder _bookBuilder;
        private readonly JournalBuilder _journalBuilder;
        private readonly NewspaperBuilder _newspaperBuilder;
        private readonly OtherFundBuilder _otherFundBuilder;
        private readonly AuthorBuilder _authorBuilder;

        public FundManager(
            IFundRepository fundRepository,
            BookBuilder bookBuilder,
            JournalBuilder journalBuilder,
            NewspaperBuilder newspaperBuilder,
            OtherFundBuilder otherFundBuilder,
            AuthorBuilder authorBuilder)
        {
            _fundRepository = fundRepository;
            _bookBuilder = bookBuilder;
            _journalBuilder = journalBuilder;
            _newspaperBuilder = newspaperBuilder;
            _otherFundBuilder = otherFundBuilder;
            _authorBuilder = authorBuilder;
        }

        public async Task<FundCollection> GetFunds(ICollection<Filter> filters, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<FundCollection> GetFunds(CancellationToken cancellationToken)
        {
            var funds = await _fundRepository.GetFunds(cancellationToken);
            var dtoBooks = await _fundRepository.GetBooks(cancellationToken);
            var dtoPeriodicLiteration = await _fundRepository.GetPeriodicLiterature(cancellationToken);
            var dtoOtherFunds = await _fundRepository.GetOtherFunds(cancellationToken);

            var bookPerFundId = dtoBooks.ToDictionary(b => b.FundId, b => b);
            var periodicLiterationPerFundId = dtoPeriodicLiteration.ToDictionary(p => p.FundId, p => p);
            var otherFundPerFundId = dtoOtherFunds.ToDictionary(o => o.FundId, o => o);

            var books = funds
                .Where(f => f.EntityId == (ushort)FundEntityEnum.Book)
                .Select(f => ToBook(f, bookPerFundId[f.Id])).ToList();
            var journals = funds
                .Where(f => f.EntityId == (ushort)FundEntityEnum.Journal)
                .Select(f => ToJournal(f, periodicLiterationPerFundId[f.Id])).ToList();
            var newspapers = funds
                .Where(f => f.EntityId == (ushort)FundEntityEnum.Newspaper)
                .Select(f => ToNewspaper(f, periodicLiterationPerFundId[f.Id])).ToList();
            var otherFunds = funds
                 .Where(f => f.EntityId == (ushort)FundEntityEnum.Other)
                .Select(f => ToOtherFund(f, otherFundPerFundId[f.Id])).ToList();

            return new FundCollection
            {
                Books = books,
                Journals = journals,
                Newspapers = newspapers,
                OtherFunds = otherFunds
            };
        }

        private Domain.Models.Funds.Author ToAuthor(Data.Dto.Author dto)
        {
            var author = _authorBuilder
                .New()
                .WithBasicInfo(dto.Id, dto.FirstName, dto.LastName, dto.BirthDate);

            if (!string.IsNullOrEmpty(dto.Country))
            {
                _authorBuilder.WithLocationCountry(dto.Country);
            }

            if (!string.IsNullOrEmpty(dto.MiddleName))
            {
                author.WithMiddleName(dto.MiddleName);
            }

            if (dto.DeathDate.HasValue)
            {
                author.WithDeathDate(dto.DeathDate.Value);
            }

            return author.Build();
        }

        private Domain.Models.Funds.Book ToBook(Data.Dto.Fund dtoFund, Data.Dto.Book dtoBook)
        {
            var authors = dtoFund.AuthorToFunds.Select(auf => ToAuthor(auf.Author));
            var copies = dtoFund.FundCopies.Select(f =>
            {
                var returnDate = f.FundUsages.FirstOrDefault(fu => fu.CopyId == f.CopyId)?.ReturnDate;
                return new FundCopy
                {
                    CopyId = f.CopyId,
                    IsInUse = returnDate != null
                };
 
            });

            return _bookBuilder.
                New()
                .WithBasicInfo(dtoFund.Id, dtoFund.Name, dtoFund.PublishDate, (FundCategoryEnum)dtoFund.CategoryId)
                .WithAuthors(authors.ToList())
                .WithCopies(copies.ToList())
                .WithBookInfo(dtoBook.Isbn)
                .Build();
        }

        private Domain.Models.Funds.Journal ToJournal(Data.Dto.Fund dtoFund, Data.Dto.PeriodicalLiterature dtoPeriodicalLiterature)
        {
            var authors = dtoFund.AuthorToFunds.Select(auf => ToAuthor(auf.Author));
            var copies = dtoFund.FundCopies.Select(f =>
            {
                var returnDate = f.FundUsages.FirstOrDefault(fu => fu.CopyId == f.CopyId)?.ReturnDate;
                return new FundCopy
                {
                    CopyId = f.CopyId,
                    IsInUse = returnDate != null
                };

            });

            return _journalBuilder.
                New()
                .WithBasicInfo(dtoFund.Id, dtoFund.Name, dtoFund.PublishDate, (FundCategoryEnum)dtoFund.CategoryId)
                .WithAuthors(authors.ToList())
                .WithCopies(copies.ToList())
                .WithJournalInfo(dtoPeriodicalLiterature.Issn)
                .Build();
        }

        private Domain.Models.Funds.Newspaper ToNewspaper(Data.Dto.Fund dtoFund, Data.Dto.PeriodicalLiterature dtoPeriodicalLiterature)
        {
            var authors = dtoFund.AuthorToFunds.Select(auf => ToAuthor(auf.Author));
            var copies = dtoFund.FundCopies.Select(f =>
            {
                var returnDate = f.FundUsages.FirstOrDefault(fu => fu.CopyId == f.CopyId)?.ReturnDate;
                return new FundCopy
                {
                    CopyId = f.CopyId,
                    IsInUse = returnDate != null
                };

            });

            return _newspaperBuilder.
                New()
                .WithBasicInfo(dtoFund.Id, dtoFund.Name, dtoFund.PublishDate, (FundCategoryEnum)dtoFund.CategoryId)
                .WithAuthors(authors.ToList())
                .WithCopies(copies.ToList())
                .WithNewspaperInfo(dtoPeriodicalLiterature.Issn)
                .Build();
        }

        private Domain.Models.Funds.OtherFund ToOtherFund(Data.Dto.Fund dtoFund, Data.Dto.FundOther dtoOther)
        {
            var authors = dtoFund.AuthorToFunds.Select(auf => ToAuthor(auf.Author));
            var copies = dtoFund.FundCopies.Select(f =>
            {
                var returnDate = f.FundUsages.FirstOrDefault(fu => fu.CopyId == f.CopyId)?.ReturnDate;
                return new FundCopy
                {
                    CopyId = f.CopyId,
                    IsInUse = returnDate != null
                };

            });

            return _otherFundBuilder.
                New()
                .WithBasicInfo(dtoFund.Id, dtoFund.Name, dtoFund.PublishDate, (FundCategoryEnum)dtoFund.CategoryId)
                .WithAuthors(authors.ToList())
                .WithCopies(copies.ToList())
                .WithOtherInfo(dtoOther.UniqueNumber)
                .Build();
        }
    }
}
