using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Dto
{
    public partial class FundOther
    {
        public uint FundId { get; set; }
        public string UniqueNumber { get; set; }

        public virtual Fund Fund { get; set; }
    }
}
