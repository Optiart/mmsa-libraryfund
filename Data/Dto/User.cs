using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Dto
{
    public partial class User
    {
        public User()
        {
            LibraryVisits = new HashSet<LibraryVisit>();
            Subscriptions = new HashSet<Subscription>();
        }

        public uint Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public DateTime BirthDate { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string CountryCode { get; set; }
        public DateTime RegistrationDate { get; set; }
        public ushort? CategoryId { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual UserCategory Category { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Lecturer Lecturer { get; set; }
        public virtual Librarian Librarian { get; set; }
        public virtual OtherUser OtherUser { get; set; }
        public virtual Retiree Retiree { get; set; }
        public virtual Schoolchild Schoolchild { get; set; }
        public virtual Scientist Scientist { get; set; }
        public virtual Student Student { get; set; }
        public virtual ICollection<LibraryVisit> LibraryVisits { get; set; }
        public virtual ICollection<Subscription> Subscriptions { get; set; }
    }
}
