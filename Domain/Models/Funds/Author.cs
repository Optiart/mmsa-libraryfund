namespace Domain.Models.Funds
{
    public class Author : Person
    {
        public FundCollection WrittenFunds { get; set; } = new();
    }
}
