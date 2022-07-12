using System;
using System.Collections.Generic;
using System.Text;

namespace FiboInfraStructure.Entity.FiboInventory
{
    public class StockAdjustment: BaseCounterEntity
    {
        public DateTime? AdjustmentDate { get; set; }
        public long? AdjustedBy { get; set; }
    }
}
