using System;

namespace Domain.Models
{
    public class Location
    {
        public string Country { get; internal set; }

        public string City { get; internal set; }

        public string Address { get; internal set; }

        public Location()
        {
        }

        public Location(string city, string address, string country)
        {
            City = city ?? throw new ArgumentNullException(nameof(city));
            Address = address ?? throw new ArgumentNullException(nameof(address));
            Country = country ?? throw new ArgumentNullException(nameof(country));
        }
    }
}
