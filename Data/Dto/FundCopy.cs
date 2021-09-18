using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Dto
{
    public partial class FundCopy
    {
        public FundCopy()
        {
            FundUsages = new HashSet<FundUsage>();
            Storages = new HashSet<Storage>();
        }

        public uint FundId { get; set; }
        public uint CopyId { get; set; }
        public uint LibraryId { get; set; }

        public virtual Fund Fund { get; set; }
        public virtual Library Library { get; set; }
        public virtual ICollection<FundUsage> FundUsages { get; set; }
        public virtual ICollection<Storage> Storages { get; set; }
    }
}
