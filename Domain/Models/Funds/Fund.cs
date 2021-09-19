using Domain.Enum;
using System;
using System.Collections.Generic;

namespace Domain.Models.Funds
{
    public abstract class Fund
    {
        public uint Id { get; set; }

        public FundCategoryEnum Category { get; set; }

        public abstract FundEntityEnum Entity { get;  }

        public string Name { get; set; }

        public DateTime PublishDate { get; set; }

        public ICollection<Author> Authors { get; set; }

        public ICollection<FundCopy> Copies { get; set; }

        public abstract string GetUniqueNumber();
    }
}
