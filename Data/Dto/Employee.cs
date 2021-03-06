using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Dto
{
    public partial class Employee
    {
        public uint UserId { get; set; }
        public string Position { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual User User { get; set; }
    }
}
