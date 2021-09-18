using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Dto
{
    public partial class Schoolchild
    {
        public uint UserId { get; set; }
        public string School { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual User User { get; set; }
    }
}
