using FiboInfraStructure.Src;
using System;
using System.Collections.Generic;
using System.Text;

namespace FiboOffice.Src.Dto
{
    public class TaxDto : BaseDto
    {
        public string Name { get; set; }
        public decimal TaxPercent { get; set; }
        public string Status { get; set; }
    }
}
