using Domain.Enum;

namespace Domain.Models.Funds
{
    public class OtherFund : Fund
    {
        public string UniqueNumber { get; set; }

        public override FundEntityEnum Entity => FundEntityEnum.Other;

        public override string GetUniqueNumber() => UniqueNumber;
    }
}
