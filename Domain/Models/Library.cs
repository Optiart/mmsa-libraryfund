using System.Collections.Generic;

namespace Domain.Models
{
    public class Library
    {
        public uint Id { get; internal set; }

        public string Name { get; internal set; }

        public Location Location { get; internal set;}

        public IReadOnlyCollection<StorageRoom> StorageRooms { get; internal set; }

        public IReadOnlyCollection<ReadingRoom> ReadingRooms { get; internal set; }
    }
}
