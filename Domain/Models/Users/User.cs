using Domain.Enum;
using System;

namespace Domain.Models.Users
{
    public abstract class User : Person
    {
        public Phone Phone { get; internal set; }

        public DateTime RegistrationDate { get; internal set; }

        public UserCategoryEnum Category { get; internal set; }
    }
}
