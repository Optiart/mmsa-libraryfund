using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Dto
{
    public partial class FundUsage
    {
        public uint Id { get; set; }
        public uint SubscriptionId { get; set; }
        public uint FundId { get; set; }
        public uint CopyId { get; set; }
        public uint LibraryId { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public uint LibrarianId { get; set; }

        public virtual FundCopy FundCopy { get; set; }
        public virtual Librarian Librarian { get; set; }
        public virtual Subscription Subscription { get; set; }
    }
}
