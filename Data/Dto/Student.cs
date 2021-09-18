using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Dto
{
    public partial class Student
    {
        public uint UserId { get; set; }
        public string University { get; set; }
        public string Faculty { get; set; }
        public string GroupNumber { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual User User { get; set; }
    }
}
