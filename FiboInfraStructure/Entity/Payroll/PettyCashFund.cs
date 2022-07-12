using System;
using System.Collections.Generic;
using System.Text;

namespace FiboInfraStructure.Entity.Payroll
{
   public class PettyCashFund :BaseEntity
    {
        public string Date { get; set; }
        public string Amount { get; set; }
        public string Quantity { get; set; }
        public string Total { get; set; }
    }
}
