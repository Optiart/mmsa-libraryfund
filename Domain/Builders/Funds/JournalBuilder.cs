using Domain.Models.Funds;
using System;

namespace Domain.Builders.Funds
{
    public class JournalBuilder : FundBuilder<Journal, JournalBuilder>
    {
        public JournalBuilder WithJournalInfo(string issn)
        {
            Fund.Issn = issn ?? throw new ArgumentNullException(nameof(issn));
            return BuilderInstance;
        }
    }
}
