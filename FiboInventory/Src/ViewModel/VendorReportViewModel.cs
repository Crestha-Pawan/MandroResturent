using FiboInfraStructure.Entity.FiboInventory;
using FiboInfraStructure.Entity.FiboOffice;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FiboInventory.Src.ViewModel
{
    public class VendorReportViewModel
    {
        public virtual List<VendorReportViewModel> VedorReportVMList { get; set; }
        public virtual List<Vendor> VedorList { get; set; }
        public virtual List<Inventory> InventoryList { get; set; }

        [NotMapped]
        public DateTime? FromDate { get; set; }
        [NotMapped]
        public DateTime? ToDate { get; set; }
        [NotMapped]
        public string FromMiti { get; set; }
        [NotMapped]
        public string ToMiti { get; set; }

        public long VendorId { get; set; }
        public long ItemId { get; set; }
        public IList<Item> Items { get; set; } = new List<Item>();
        public SelectList ItemList => new SelectList(Items, nameof(Item.Id), nameof(Item.Name));
        public IList<Vendor> Vendors { get; set; } = new List<Vendor>();
        public SelectList VendorLists => new SelectList(Items, nameof(Vendor.Id), nameof(Vendor.VendorName));
    }
}
