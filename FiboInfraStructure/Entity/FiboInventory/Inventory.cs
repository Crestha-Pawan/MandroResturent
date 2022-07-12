using FiboInfraStructure.Entity.FiboInventory;
using FiboInfraStructure.Entity.FiboOffice;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FiboInfraStructure.Entity.FiboInventory
{
    public class Inventory : BaseCounterEntity
    {
        
        [ForeignKey("ItemId")]
        public long? ItemId { get; set; }

        [ForeignKey("VendorId")]
        public long? VendorId { get; set; }
        public string Quantity { get; set; }
        public decimal ActualQuantity { get; set; }
        public decimal AvailableQuantity { get; set; }
        public decimal ConsumedQuantity { get; set; }
        public string Rate { get; set; }
        public string Total { get; set; }
        public DateTime? Date { get; set; }
        public virtual Item Item { get; set; }
        

    }
}
