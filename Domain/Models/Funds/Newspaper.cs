using Domain.Enum;

namespace Domain.Models.Funds
{
    public class Newspaper : PeriodicalLiterature
    {
        public override FundEntityEnum Entity => FundEntityEnum.Newspaper;

        public override string GetUniqueNumber() => Issn;
    }
}
