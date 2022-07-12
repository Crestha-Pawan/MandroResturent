using FiboInfraStructure.Src;
using System;
using System.Collections.Generic;
using System.Text;

namespace FiboOffice.Src.Dto
{
    public class VendorDto: BaseDto
    {
        public string VendorName { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }
    }
}
