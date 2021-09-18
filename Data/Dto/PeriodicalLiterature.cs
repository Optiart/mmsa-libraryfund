using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Dto
{
    public partial class PeriodicalLiterature
    {
        public uint FundId { get; set; }
        public string Issn { get; set; }
        public ushort? Issue { get; set; }

        public virtual Fund Fund { get; set; }
    }
}
