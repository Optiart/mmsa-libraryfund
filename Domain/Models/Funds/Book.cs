using Domain.Enum;

namespace Domain.Models.Funds
{
    public class Book : Fund
    {
        public override FundEntityEnum Entity => FundEntityEnum.Book;

        public string Isbn { get; set; }

        public override string GetUniqueNumber() => Isbn;
    }
}
