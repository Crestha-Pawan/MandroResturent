using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FiboInfraStructure.Entity.FiboInventory
{
    public class InventorySummary : BaseCounterEntity
    {
        public DateTime? StockDate { get; set; }
        [ForeignKey("InventoryId")]
        public long? InventoryId { get; set; }

        public decimal StockInHand { get; set; }

        public decimal AddedStock { get; set; }

        public decimal ClosingStock { get; set; }

        public decimal PurchasePrice { get; set; }
        [NotMapped()]
        public virtual Inventory Inventory { get; set; }

    }
}
