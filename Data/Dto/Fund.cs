using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Dto
{
    public partial class Fund
    {
        public Fund()
        {
            AuthorToFunds = new HashSet<AuthorToFund>();
            FundCopies = new HashSet<FundCopy>();
        }

        public uint Id { get; set; }
        public ushort EntityId { get; set; }
        public ushort CategoryId { get; set; }
        public ushort UsageRuleId { get; set; }
        public string Name { get; set; }
        public DateTime PublishDate { get; set; }

        public virtual FundCategory Category { get; set; }
        public virtual FundEntity Entity { get; set; }
        public virtual FundUsageRule UsageRule { get; set; }
        public virtual Book Book { get; set; }
        public virtual FundOther FundOther { get; set; }
        public virtual PeriodicalLiterature PeriodicalLiterature { get; set; }
        public virtual ICollection<AuthorToFund> AuthorToFunds { get; set; }
        public virtual ICollection<FundCopy> FundCopies { get; set; }
    }
}
