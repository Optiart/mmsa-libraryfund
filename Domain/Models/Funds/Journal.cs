using Domain.Enum;

namespace Domain.Models.Funds
{
    public class Journal : PeriodicalLiterature
    {
        public override FundEntityEnum Entity => FundEntityEnum.Journal;

        public override string GetUniqueNumber() => Issn;
    }
}
