using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Dto
{
    public partial class Author
    {
        public Author()
        {
            AuthorToFunds = new HashSet<AuthorToFund>();
        }

        public uint Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime? DeathDate { get; set; }
        public string Country { get; set; }

        public virtual ICollection<AuthorToFund> AuthorToFunds { get; set; }
    }
}
