using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Dto
{
    public partial class OtherUser
    {
        public uint UserId { get; set; }

        public virtual User User { get; set; }
    }
}
