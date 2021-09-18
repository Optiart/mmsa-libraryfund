using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Dto
{
    public partial class AuthorToFund
    {
        public uint AuthorId { get; set; }
        public uint FundId { get; set; }

        public virtual Author Author { get; set; }
        public virtual Fund Fund { get; set; }
    }
}
