using Domain.Enum;
using Domain.Models;
using Domain.Models.Users;
using System;

namespace Domain.Builders.Users
{
    public abstract class UserBuilder<T> where T : User, new()
    {
        protected readonly T User;

        public UserBuilder()
        {
            User = new T();
        }

        public UserBuilder<T> WithBasicInfo(uint id, string firstName, string lastName, DateTime birthDate)
        {
            User.Id = id;
            User.FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
            User.LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));

            if (birthDate == default)
            {
                throw new ArgumentException("Invalid birth date", nameof(birthDate));
            }

            User.BirthDate = birthDate;
            User.Category = GetUserCategory();
            return this;
        }

        private UserCategoryEnum GetUserCategory()
        {
            return typeof(T).Name switch
            {
                "Librarian" => UserCategoryEnum.Librarian,
                _ => throw new NotSupportedException($"user category {typeof(T).Name} is not supported")
            };
        }

        public UserBuilder<T> WithMiddleName(string middleName)
        {
            User.MiddleName = middleName ?? throw new ArgumentNullException(nameof(middleName));
            return this;
        }

        public UserBuilder<T> WithLocation(string city, string address)
        {
            User.Location = new Location(city, address);
            return this;
        }

        public UserBuilder<T> WithPhone(string number, string countryCode)
        {
            User.Phone = new Phone(number, countryCode);
            return this;
        }

        public UserBuilder<T> AsNewUser()
        {
            User.RegistrationDate = DateTime.UtcNow;
            return this;
        }

        public UserBuilder<T> AsExistingUser(DateTime registrationDate)
        {
            User.RegistrationDate = registrationDate;
            return this;
        }

        public T Build() => User;
    }
}
