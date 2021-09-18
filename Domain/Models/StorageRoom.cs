using System;

namespace Domain.Models
{
    public class StorageRoom
    {
        public ushort Id { get; }

        public string Name { get; }

        public byte Floor { get; }

        public StorageRoom(ushort id, string name, byte floor)
        {
            Id = id;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Floor = floor;
        }
    }
}
