using Domain.Models.Users;
using System;

namespace Domain.Builders.Users
{
    public class LibrarianUserBuilder : UserBuilder<Librarian, LibrarianUserBuilder>
    {
        public LibrarianUserBuilder WithLibrarianInfo(string position, DateTime startDate, DateTime? endDate = default)
        {
            Person.Position = position ?? throw new ArgumentNullException(nameof(position));

            if (startDate == default)
            {
                throw new ArgumentException(null, nameof(startDate));
            }

            Person.StartDate = startDate;
            Person.EndDate = endDate;
            return BuilderInstance;
        }
    }
}
