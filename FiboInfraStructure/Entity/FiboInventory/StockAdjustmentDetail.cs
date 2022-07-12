using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FiboInfraStructure.Entity.FiboInventory
{
    public class StockAdjustmentDetail: BaseEntity
    {
        [ForeignKey("StockAdjustmentId")]
        public long? StockAdjustmentId { get; set; }
        public long? ItemId { get; set; }
        [ForeignKey("MeasuringUnitId")]
        public long? MeasuringUnitId { get; set; }
        public string Quantity { get; set; }
    }
}
