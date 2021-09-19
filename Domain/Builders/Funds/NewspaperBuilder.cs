using Domain.Models.Funds;
using System;

namespace Domain.Builders.Funds
{
    public class NewspaperBuilder : FundBuilder<Newspaper, NewspaperBuilder>
    {
        public NewspaperBuilder WithNewspaperInfo(string issn)
        {
            Fund.Issn = issn ?? throw new ArgumentNullException(nameof(issn));
            return BuilderInstance;
        }
    }
}
