using FiboInfraStructure.Src;
using System;
using System.Collections.Generic;
using System.Text;

namespace FiboInventory.Src.Dto
{
    public class InventorySummaryDto : BaseDto
    {
        public DateTime? StockDate { get; set; }
        public long? InventoryId { get; set; }
        public decimal StockInHand { get; set; }
        public decimal AddedStock { get; set; }
        public decimal ClosingStock { get; set; }
        public decimal PurchasePrice { get; set; }
    }
}
