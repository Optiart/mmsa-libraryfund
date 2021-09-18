using Domain.Models.Users;
using System;

namespace Domain.Builders.Users
{
    public class EmployeeUserBuilder : UserBuilder<Employee>
    {
        public UserBuilder<Employee> WithEmployeeInfo(string position, DateTime startDate, DateTime? endDate = default)
        {
            User.Position = position ?? throw new ArgumentNullException(nameof(position));

            if (startDate == default)
            {
                throw new ArgumentException(null, nameof(startDate));
            }

            User.StartDate = startDate;
            User.EndDate = endDate;
            return this;
        }
    }
}
