using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Builders
{
    public class LibraryBuilder
    {
        private readonly Library _library;

        public LibraryBuilder()
        {
            _library = new Library();
        }

        public LibraryBuilder WithBasicInfo(uint id, string name, string city, string address)
        {
            _library.Id = id;
            _library.Name = name ?? throw new ArgumentNullException(nameof(name));
            _library.Location = new Location(city, address);
            return this;
        }

        public LibraryBuilder WithStorageRooms(IEnumerable<StorageRoom> storageRooms)
        {
            _library.StorageRooms = storageRooms.ToList();
            return this;
        }

        public LibraryBuilder WithReadingRooms(IEnumerable<ReadingRoom> readingRooms)
        {
            _library.ReadingRooms = readingRooms.ToList();
            return this;
        }

        public Library Build() => _library;
    }
}
