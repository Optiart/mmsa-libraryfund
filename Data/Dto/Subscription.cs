using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Dto
{
    public partial class Subscription
    {
        public Subscription()
        {
            FundUsages = new HashSet<FundUsage>();
            LibraryVisits = new HashSet<LibraryVisit>();
        }

        public uint Id { get; set; }
        public string Number { get; set; }
        public uint UserId { get; set; }
        public uint LibraryId { get; set; }
        public DateTime IssueDate { get; set; }
        public ushort? ValidDays { get; set; }
        public DateTime? ExtendDate { get; set; }

        public virtual Library Library { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<FundUsage> FundUsages { get; set; }
        public virtual ICollection<LibraryVisit> LibraryVisits { get; set; }
    }
}
