using Domain.Models.Funds;
using System.Linq;

namespace CityLibraryFund.ViewModels
{
    public class FundViewModel
    {
        public uint Id { get; set; }

        public string Category { get; set; }

        public string Name { get; set; }

        public string Authors { get; set; }

        public string UniqueNumber { get; set; }

        public string PublishDate { get; set; }

        public string CopyCount { get; set; }

        public FundViewModel()
        {
        }

        public FundViewModel(Fund fund)
        {
            Id = fund.Id;
            Name = fund.Name;
            PublishDate = fund.PublishDate.ToString("F");
            CopyCount = fund.Copies.Count.ToString();
            Authors = string.Join(",", fund.Authors.Select(a => $"{a.LastName} {a.MiddleName} {a.FirstName}"));
        }
    }
}
