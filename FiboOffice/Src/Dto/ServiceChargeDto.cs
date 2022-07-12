using FiboInfraStructure.Src;
using System;
using System.Collections.Generic;
using System.Text;

namespace FiboOffice.Src.Dto
{
    public class ServiceChargeDto: BaseDto
    {
        public string Name { get; set; }
        public decimal ServicePercent { get; set; }
        public string Status { get; set; }
    }
}
