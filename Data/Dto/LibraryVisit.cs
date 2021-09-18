using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Dto
{
    public partial class LibraryVisit
    {
        public uint Id { get; set; }
        public uint UserId { get; set; }
        public uint SubscriptionId { get; set; }
        public uint ReadingRoomId { get; set; }
        public uint LibraryId { get; set; }
        public DateTime? VisitDate { get; set; }

        public virtual Library Library { get; set; }
        public virtual ReadingRoom ReadingRoom { get; set; }
        public virtual Subscription Subscription { get; set; }
        public virtual User User { get; set; }
    }
}
