using Domain.Models.Funds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityLibraryFund.ViewModels
{
    public class FundViewModel
    {
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
            Name = fund.Name;
            PublishDate = fund.PublishDate.ToString("F");
            CopyCount = fund.Copies.Count.ToString();
            Authors = string.Join(",", fund.Authors.Select(a => $"{a.LastName} {a.MiddleName} {a.FirstName}"));
        }
    }
}
