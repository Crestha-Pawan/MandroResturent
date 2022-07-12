using FiboInfraStructure.Entity.FiboBilling;
using System;
using System.Collections.Generic;
using System.Text;

namespace FiboBilling.Src.ViewModel
{
    public class BillingViewModel
    {
        public virtual List<Billing> Billings { get; set; }
        public virtual List<Table> Tables { get; set; }
    }
}
