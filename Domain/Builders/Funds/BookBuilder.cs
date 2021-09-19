using Domain.Models.Funds;
using System;

namespace Domain.Builders.Funds
{
    public class BookBuilder : FundBuilder<Book, BookBuilder>
    {
        public BookBuilder WithBookInfo(string isbn)
        {
            Fund.Isbn = isbn ?? throw new ArgumentNullException(nameof(isbn));
            return BuilderInstance;
        }
    }
}
