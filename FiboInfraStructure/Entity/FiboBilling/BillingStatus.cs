using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FiboInfraStructure.Entity.FiboBilling
{
    public  class BillingStatus:BaseEntity
    {
        public bool IsPaid { get; set; }
        
        public long? BillingId { get; set; }
    }
}
