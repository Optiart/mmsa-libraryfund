using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Dto
{
    public partial class Retiree
    {
        public uint UserId { get; set; }
        public DateTime StartDate { get; set; }

        public virtual User User { get; set; }
    }
}
