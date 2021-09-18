using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Dto
{
    public partial class FundEntity
    {
        public FundEntity()
        {
            Funds = new HashSet<Fund>();
        }

        public ushort Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Fund> Funds { get; set; }
    }
}
