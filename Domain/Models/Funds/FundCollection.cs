using System;
using System.Collections.Generic;

namespace Domain.Models.Funds
{
    public class FundCollection
    {
        public ICollection<Book> Books { get; set; } = Array.Empty<Book>();

        public ICollection<Journal> Journals { get; set; } = Array.Empty<Journal>();

        public ICollection<Newspaper> Newspapers { get; set; } = Array.Empty<Newspaper>();

        public ICollection<OtherFund> OtherFunds { get; set; } = Array.Empty<OtherFund>();
    }
}
