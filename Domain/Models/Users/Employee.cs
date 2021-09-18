using System;

namespace Domain.Models.Users
{
    public class Employee : User
    {
        public string Position { get; internal set; }

        public DateTime StartDate { get; internal set; }

        private DateTime? _endDate;

        public DateTime? EndDate { 
            get => _endDate;
            internal set
            {
                if (value < StartDate)
                {
                    throw new InvalidOperationException("End date should be later than start date");
                }

                _endDate = value;
            }
        }

        public void Retire(DateTime? endDate = default)
        {
            if (EndDate != null)
            {
                throw new InvalidOperationException("Can't retire already retired employee");
            }

            EndDate = endDate ?? DateTime.UtcNow;
        }
    }
}
