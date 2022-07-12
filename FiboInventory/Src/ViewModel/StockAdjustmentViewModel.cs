using FiboInfraStructure.Entity.FiboInventory;
using System;
using System.Collections.Generic;
using System.Text;

namespace FiboInventory.Src.ViewModel
{
    public class StockAdjustmentViewModel
    {
        public List<StockAdjustment> StockAdjustmentList { get; set; }
        public List<StockAdjustmentDetail> StockAdjustmentDetailList { get; set; }
    }
}
