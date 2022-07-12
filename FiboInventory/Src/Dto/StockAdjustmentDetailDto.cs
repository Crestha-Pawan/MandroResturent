using FiboInfraStructure.Src;
using System;
using System.Collections.Generic;
using System.Text;

namespace FiboInventory.Src.Dto
{
    public class StockAdjustmentDetailDto: BaseDto
    {
        public long? StockAdjustmentId { get; set; }
        public long? ItemId { get; set; }
        public long? MeasuringUnitId { get; set; }
        public string Quantity { get; set; }
    }
}
