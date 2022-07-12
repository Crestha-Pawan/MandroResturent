using System;
using System.Collections.Generic;
using System.Text;

namespace FiboInfraStructure.Entity.FiboOffice
{
    public class DayCashBook: BaseEntity
    {
        public DateTime? OpeningDate { get; set; }
        public string OpeningBalance { get; set; }
    }
}
