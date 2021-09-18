using System;

namespace Domain.Models
{
    public class Location
    {
        public string City { get; }

        public string Address { get; }

        public Location(string city, string address)
        {
            City = city ?? throw new ArgumentNullException(nameof(city));
            Address = address ?? throw new ArgumentNullException(nameof(address));
        }
    }
}
