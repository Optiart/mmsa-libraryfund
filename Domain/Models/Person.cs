using System;

namespace Domain.Models
{
    public abstract class Person
    {
        public uint Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MiddleName { get; set; }

        public DateTime BirthDate { get; set; }

        public DateTime? DeathDate { get; set; }

        public Location Location { get; internal set; } = new Location();
    }
}
