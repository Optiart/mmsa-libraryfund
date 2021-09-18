using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Dto
{
    public partial class UserCategory
    {
        public UserCategory()
        {
            Users = new HashSet<User>();
        }

        public ushort Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
