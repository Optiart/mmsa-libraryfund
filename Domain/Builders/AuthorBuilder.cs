using Domain.Models.Funds;
using System.Collections.Generic;

namespace Domain.Builders
{
    public class AuthorBuilder : PersonBuilder<Author, AuthorBuilder>
    {
        public AuthorBuilder WithBooks(ICollection<Book> books)
        {
            Person.WrittenFunds.Books = books;
            return this;
        }

        public AuthorBuilder WithJournals(ICollection<Journal> journals)
        {
            Person.WrittenFunds.Journals = journals;
            return this;
        }

        public AuthorBuilder WithNewspapers(ICollection<Newspaper> newspapers)
        {
            Person.WrittenFunds.Newspapers = newspapers;
            return this;
        }

        public AuthorBuilder WithOtherFunds(ICollection<OtherFund> otherFunds)
        {
            Person.WrittenFunds.OtherFunds = otherFunds;
            return this;
        }
    }
}
