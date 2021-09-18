using Domain.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Models
{
    public class ReadingRoom
    {
        public uint Id { get; }

        public string Name { get; }

        public ICollection<Librarian> Librarians { get; }

        public ReadingRoom(uint id, string name, IEnumerable<Librarian> librarians)
        {
            Id = id;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Librarians = librarians?.ToList() ?? throw new ArgumentNullException(nameof(librarians));
        }

        public ReadingRoom(uint id, string name)
        {
            Id = id;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Librarians = new List<Librarian>();
        }

        public void AssignLibrarian(Librarian librarian) => Librarians.Add(librarian);

        public void RemoveLibrarian(Librarian librarian) => Librarians.Remove(librarian);
    }
}
