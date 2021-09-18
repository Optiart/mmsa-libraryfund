using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Dto
{
    public partial class Book
    {
        public uint FundId { get; set; }
        public string Isbn { get; set; }

        public virtual Fund Fund { get; set; }
    }
}
