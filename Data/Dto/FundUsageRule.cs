using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Dto
{
    public partial class FundUsageRule
    {
        public FundUsageRule()
        {
            Funds = new HashSet<Fund>();
        }

        public ushort Id { get; set; }
        public bool InternalUsage { get; set; }
        public ushort? MaxBorrowDays { get; set; }

        public virtual ICollection<Fund> Funds { get; set; }
    }
}
