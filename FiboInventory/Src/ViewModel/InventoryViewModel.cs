using FiboInfraStructure.Entity.FiboInventory;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FiboInventory.Src.ViewModel
{
    public class InventoryViewModel
    {
        public virtual List<Inventory> Inventories { get; set; }
        public virtual List<InventoryViewModel> InventoryVMList { get; set; }
        public long? ItemId { get; set; }
        public string LastPurchaseDate { get; set; }
        public long? InvId { get; set; }
        public string Quantity { get; set; }
        public string Total { get; set; }
        public string LastPurchaseQuantity { get; set; }
        public string LastPurchasePrice { get; set; }
        [NotMapped]
        public DateTime? FromDate { get; set; }
        [NotMapped]
        public DateTime? ToDate { get; set; }

        public DateTime? Date { get; set; }

        [NotMapped]
        public string FromMiti { get; set; }
        [NotMapped]
        public string ToMiti { get; set; }
        public IList<Item> Items { get; set; } = new List<Item>();
        public SelectList ItemList => new SelectList(Items, nameof(Item.Id), nameof(Item.Name));
    }
}
