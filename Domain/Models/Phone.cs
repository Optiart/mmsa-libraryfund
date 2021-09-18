using System;

namespace Domain.Models
{
    public class Phone
    {
        public string Number { get; }

        public string CountryCode { get; }

        public Phone(string number, string countryCode)
        {
            Number = number ?? throw new ArgumentNullException(nameof(number));
            CountryCode = countryCode ?? throw new ArgumentNullException(nameof(countryCode));
        }
    }
}
