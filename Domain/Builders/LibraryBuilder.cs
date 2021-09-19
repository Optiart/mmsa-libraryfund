using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Builders
{
    public class LibraryBuilder
    {
        private Library _library;

        public LibraryBuilder()
        {
        }

        public LibraryBuilder New()
        {
            _library = new Library();
            return this;
        }

        public LibraryBuilder WithBasicInfo(uint id, string name, string city, string address, string country = default)
        {
            _library.Id = id;
            _library.Name = name ?? throw new ArgumentNullException(nameof(name));
            
            if (string.IsNullOrEmpty(country))
            {
                country = "Україна";
            }

            _library.Location = new Location(city, address, country);
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
