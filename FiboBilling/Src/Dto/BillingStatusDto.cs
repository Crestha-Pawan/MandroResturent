using FiboInfraStructure.Src;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FiboBilling.Src.Dto
{
    public  class BillingStatusDto:BaseDto
    {
        public bool IsPaid { get; set; }
        [NotMapped()]
        public long? BillingId { get; set; }
    }
}
