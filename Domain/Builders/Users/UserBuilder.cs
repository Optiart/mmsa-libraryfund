using Domain.Enum;
using Domain.Models;
using Domain.Models.Users;
using System;

namespace Domain.Builders.Users
{
    public abstract class UserBuilder<TUser, TBuilder> : PersonBuilder<TUser, TBuilder>
        where TUser : User, new()
        where TBuilder: UserBuilder<TUser,TBuilder>
    {
        public TBuilder WithCategory(UserCategoryEnum category)
        {
            Person.Category = category;
            return BuilderInstance;
        }

        public TBuilder WithPhone(string number, string countryCode)
        {
            Person.Phone = new Phone(number, countryCode);
            return BuilderInstance;
        }

        public TBuilder AsNewUser()
        {
            Person.RegistrationDate = DateTime.UtcNow;
            return BuilderInstance;
        }

        public TBuilder AsExistingUser(DateTime registrationDate)
        {
            Person.RegistrationDate = registrationDate;
            return BuilderInstance;
        }
    }
}
