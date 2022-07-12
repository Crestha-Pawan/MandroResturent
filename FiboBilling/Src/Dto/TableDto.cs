using FiboInfraStructure.Src;
using System;
using System.Collections.Generic;
using System.Text;

namespace FiboBilling.Src.Dto
{
    public class TableDto: BaseDto
    {
        public string Name { get; set; }
        public int ReferenceType { get; set; }
    }
}
