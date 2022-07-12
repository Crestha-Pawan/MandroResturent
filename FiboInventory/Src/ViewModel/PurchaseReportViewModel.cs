using FiboInfraStructure.Entity.FiboInventory;
using FiboInfraStructure.Entity.FiboOffice;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace FiboInventory.Src.ViewModel
{
    public class PurchaseReportViewModel
    {
        public List<Inventory> InventoryList { get; set; }
        public List<PurchaseReportViewModel> PurchaseReportVMList { get; set; }
        public List<Month> MonthList { get; set; }
        public long? ItemId { get; set; }
        public long? YearId { get; set; }
        public long? MonthId { get; set; }
        public IList<Year> Years { get; set; } = new List<Year>();
        public SelectList YearList => new SelectList(Years, nameof(Year.Id), nameof(Year.YearName));
    }
}
