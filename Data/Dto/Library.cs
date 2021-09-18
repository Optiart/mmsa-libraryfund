using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Dto
{
    public partial class Library
    {
        public Library()
        {
            FundCopies = new HashSet<FundCopy>();
            LibraryVisits = new HashSet<LibraryVisit>();
            ReadingRooms = new HashSet<ReadingRoom>();
            StorageRooms = new HashSet<StorageRoom>();
            Subscriptions = new HashSet<Subscription>();
        }

        public uint Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Address { get; set; }

        public virtual ICollection<FundCopy> FundCopies { get; set; }
        public virtual ICollection<LibraryVisit> LibraryVisits { get; set; }
        public virtual ICollection<ReadingRoom> ReadingRooms { get; set; }
        public virtual ICollection<StorageRoom> StorageRooms { get; set; }
        public virtual ICollection<Subscription> Subscriptions { get; set; }
    }
}
