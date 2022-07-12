using FiboInfraStructure.Entity.FiboInventory;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace FiboInventory.Src.ViewModel
{
     public class InventoryReportViewModel
    {
        public virtual List<InventoryReportViewModel> Inventories { get; set; }

        public long ItemId { get; set; }
        public decimal AvailableQuantity { get; set; }
        public decimal ActualQuantity { get; set; }
        public decimal ConsumedQuantity { get; set; }
        public long MeasuringUnitId { get; set; }
        public IList<Item> Items { get; set; } = new List<Item>();
        public SelectList ItemList => new SelectList(Items, nameof(Item.Id), nameof(Item.Name));
    }
}
