using Domain.Models.Funds;
using System;

namespace Domain.Builders.Funds
{
    public class OtherFundBuilder : FundBuilder<OtherFund, OtherFundBuilder>
    {
        public OtherFundBuilder WithOtherInfo(string uniqueNumber)
        {
            Fund.UniqueNumber = uniqueNumber ?? throw new ArgumentNullException(nameof(uniqueNumber));
            return BuilderInstance;
        }
    }
}
