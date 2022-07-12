using FiboInfraStructure.Entity.FiboInventory;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FiboInfraStructure.Entity.FiboBilling
{
    public class BillingInfo : BaseCounterEntity
    {
        [ForeignKey("BillingId")]
        public long? BillingId { get; set; }
        public long? Rate { get; set; }
        public long? Quantity { get; set; }

        [ForeignKey("ProductId")]
        public long? ProductId { get; set; }
        public decimal Price { get; set; }
        public decimal Amount { get; set; }
        public string Remarks { get; set; }
        public bool IsKOT { get; set; }
        public bool IsTakeAway { get; set; }
        public string TakeAwayQuantity { get; set; }
        public string Order { get; set; }
        public virtual Billing Billing { get; set; }

        public virtual Product Product { get; set; }
    }
}
