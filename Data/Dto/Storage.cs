using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Dto
{
    public partial class Storage
    {
        public uint Id { get; set; }
        public ushort StorageRoomId { get; set; }
        public uint FundId { get; set; }
        public uint CopyId { get; set; }
        public uint LibraryId { get; set; }
        public ushort RoomNumber { get; set; }
        public ushort RackNumber { get; set; }
        public ushort ShelfNumber { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime? DecommissionDate { get; set; }

        public virtual FundCopy FundCopy { get; set; }
        public virtual StorageRoom StorageRoom { get; set; }
    }
}
