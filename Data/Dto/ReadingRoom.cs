using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Dto
{
    public partial class ReadingRoom
    {
        public ReadingRoom()
        {
            Librarians = new HashSet<Librarian>();
            LibraryVisits = new HashSet<LibraryVisit>();
        }

        public uint Id { get; set; }
        public uint LibraryId { get; set; }
        public string Name { get; set; }

        public virtual Library Library { get; set; }
        public virtual ICollection<Librarian> Librarians { get; set; }
        public virtual ICollection<LibraryVisit> LibraryVisits { get; set; }
    }
}
