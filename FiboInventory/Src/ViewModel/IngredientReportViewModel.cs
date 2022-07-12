using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using FiboInfraStructure.Entity.FiboBilling;
using FiboInfraStructure.Entity.FiboInventory;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FiboInventory.Src.ViewModel
{
   public class IngredientReportViewModel
    {
        public long ItemId { get; set; }
        public decimal AvailableQuantity { get; set; }
        public decimal ActualQuantity { get; set; }
        public decimal ConsumedQuantity { get; set; }
        public long MeasuringUnitId { get; set; }
        [NotMapped]
        public DateTime? FromDate { get; set; }
        [NotMapped]
        public DateTime? ToDate { get; set; }
        [NotMapped]
        public string FromMiti { get; set; }
        [NotMapped]
        public string ToMiti { get; set; }
        public List<Ingredient> Ingredientlist { get; set; }

        public virtual List<InventoryReportViewModel> Inventories { get; set; }
        public IList<Item> Items { get; set; } = new List<Item>();
        public SelectList ItemList => new SelectList(Items, nameof(Item.Id), nameof(Item.Name));
        

       
    }
}
