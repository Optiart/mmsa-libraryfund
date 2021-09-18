using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Dto
{
    public partial class Librarian
    {
        public Librarian()
        {
            FundUsages = new HashSet<FundUsage>();
        }

        public uint UserId { get; set; }
        public uint ReadingRoomId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual ReadingRoom ReadingRoom { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<FundUsage> FundUsages { get; set; }
    }
}
