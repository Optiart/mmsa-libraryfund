namespace Domain.Models.Funds
{
    public abstract class PeriodicalLiterature : Fund
    {
        public string Issn { get; set; }

        public int IssueNumber { get; set; }
    }
}
