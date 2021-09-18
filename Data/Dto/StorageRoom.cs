using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Dto
{
    public partial class StorageRoom
    {
        public StorageRoom()
        {
            Storages = new HashSet<Storage>();
        }

        public ushort Id { get; set; }
        public uint LibraryId { get; set; }
        public string Name { get; set; }
        public byte Floor { get; set; }

        public virtual Library Library { get; set; }
        public virtual ICollection<Storage> Storages { get; set; }
    }
}
