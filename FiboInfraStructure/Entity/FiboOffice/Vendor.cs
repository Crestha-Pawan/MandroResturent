using System;
using System.Collections.Generic;
using System.Text;

namespace FiboInfraStructure.Entity.FiboOffice
{
    public class Vendor: BaseCounterEntity
    {
        public string VendorName { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }
    }
}
