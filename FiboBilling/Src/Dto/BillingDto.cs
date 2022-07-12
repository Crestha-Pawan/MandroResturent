using FiboInfraStructure.Entity.FiboBilling;
using FiboInfraStructure.Entity.FiboInventory;
using FiboInfraStructure.Src;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace FiboBilling.Src.Dto
{
    public class BillingDto : BaseDto
    {
        public DateTime? BillingDate { get; set; }
        public string BillingNumber { get; set; }
        public decimal Discount { get; set; }
        public decimal Total { get; set; }
        public long? FiscalYearId { get; set; }
        public string GuestName { get; set; }
        public string KotBotBy { get; set; }
        public string TableNo { get; set; }
        public string Status { get; set; }
        public long? TableId { get; set; }
        public decimal ServiceCharge { get; set; }
        public long? ServiceChargeId { get; set; }
        public long? TaxId { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal NetAmtPayable { get; set; }
        public string PaymentMethod { get; set; }
        public bool IsClear { get; set; }
        public virtual List<ProductCategory> Categories { get; set; }
        public virtual List<BillingInfoDto> BillingInfo { get; set; }
        public virtual List<Product> OrderProducts { get; set; }
        public virtual List<Table> Tables { get; set; }
        public long? PrevTableId { get; set; }
        public IList<Product> Products { get; set; } = new List<Product>();
        public SelectList ProductList => new SelectList(Products, nameof(Product.Id), nameof(Product.Name));

        public IList<Item> Items { get; set; } = new List<Item>();
        public SelectList ItemList => new SelectList(Items, nameof(Item.Id), nameof(Item.Name));
        public IList<Table> TableList { get; set; } = new List<Table>();
        public SelectList TableSalectList => new SelectList(TableList, nameof(Table.Id), nameof(Table.Name));
    }
}
