using Domain.Models;
using System;

namespace Domain.Builders
{
    public class PersonBuilder<TPerson, TBuilder>
        where TPerson: Person, new()
        where TBuilder: PersonBuilder<TPerson, TBuilder>
    {
        protected TPerson Person;

        protected TBuilder BuilderInstance;

        public PersonBuilder() => BuilderInstance = (TBuilder)this;

        public TBuilder New()
        {
            Person = new();
            return BuilderInstance;
        }

        public TBuilder WithBasicInfo(uint id, string firstName, string lastName, DateTime birthDate)
        {
            Person.Id = id;
            Person.FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
            Person.LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));

            if (birthDate == default)
            {
                throw new ArgumentException("Invalid birth date", nameof(birthDate));
            }

            Person.BirthDate = birthDate;
            return BuilderInstance;
        }

        public TBuilder WithDeathDate(DateTime deathDate)
        {
            Person.DeathDate = deathDate;
            return BuilderInstance;
        }

        public TBuilder WithMiddleName(string middleName)
        {
            Person.MiddleName = middleName ?? throw new ArgumentNullException(nameof(middleName));
            return BuilderInstance;
        }

        public TBuilder WithLocationCity(string city)
        {
            Person.Location.City = city;
            return BuilderInstance;
        }

        public TBuilder WithLocationAddress(string address)
        {
            Person.Location.Address = address;
            return BuilderInstance;
        }

        public TBuilder WithLocationCountry(string country)
        {
            Person.Location.Country = country;
            return BuilderInstance;
        }

        public TPerson Build() => Person;
    }
}
