using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using FiboInfraStructure.Entity.FiboBilling;
using FiboInfraStructure.Entity.FiboInventory;
using FiboInfraStructure.Entity.FiboOffice;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FiboBilling.Src.ViewModel
{
   public class SalesReportViewModel
    {
        public List<SalesReportViewModel> salesvm { get; set; }
        public List<Billing> Billings { get; set; }
        public List<MeasuringUnit> MeasuringUnits { get; set; }
        public string Name { get; set; }
        public long? Quantity { get; set; }
        public decimal Total { get; set; }
        public string BillingDate { get; set; }
        public long ProductId { get; set; }
        [NotMapped]
        public DateTime? FromDate { get; set; }
        [NotMapped]
        public DateTime? ToDate { get; set; }
        [NotMapped]
        public string FromMiti { get; set; }
        [NotMapped]
        public string ToMiti { get; set; }

        public IList<Product> Products { get; set; } = new List<Product>();
        public SelectList ProductList => new SelectList(Products, nameof(Product.Id), nameof(Product.Name));
    }
}
