using Domain.Enum;
using System;

namespace Domain.Models.Users
{
    public abstract class User
    {
        public uint Id { get; internal set; }

        public string FirstName { get; internal set; }

        public string LastName { get; internal set; }

        public string MiddleName { get; internal set; }

        public DateTime BirthDate { get; internal set; }

        public Location Location { get; internal set; }

        public Phone Phone { get; internal set; }

        public DateTime RegistrationDate { get; internal set; }

        public UserCategoryEnum Category { get; internal set; }
    }
}
