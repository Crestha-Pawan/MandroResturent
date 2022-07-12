using FiboInfraStructure.Entity.FiboInventory;
using FiboInfraStructure.Entity.FiboOffice;
using FiboInfraStructure.Src;
using FiboInventory.InfraStructure.Repository;
using FiboOffice.InfraStructure.Repository;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FiboInventory.Src.Dto
{
    public class InventoryDto: BaseDto
    {
        public long? UpdateId { get; set; }
        public long? ItemId { get; set; }
        public long? VendorId { get; set; }
        public string Quantity { get; set; }
        public decimal ActualQuantity { get; set; }
        public decimal AvailableQuantity { get; set; }
        public decimal ConsumedQuantity { get; set; }
        public string Date { get; set; }
        public string Rate { get; set; }
        public string Total { get; set; }
        public virtual List<InventoryDto> InventoryInfo { get; set; }
        public IList<Item> Items { get; set; } = new List<Item>();
        public SelectList ItemList => new SelectList(Items, nameof(Item.Id), nameof(Item.Name));
        public IList<MeasuringUnit> MeasuringUnits { get; set; } = new List<MeasuringUnit>();
        public SelectList MeasuringUnitList => new SelectList(MeasuringUnits, nameof(MeasuringUnit.Id), nameof(MeasuringUnit.Name));
        public IList<Vendor> Vendors { get; set; } = new List<Vendor>();
        public SelectList VendorList => new SelectList(Vendors, nameof(Vendor.Id), nameof(Vendor.VendorName));


        public IEnumerable<SelectListItem> getItemList(IItemRepository _repo, long? Id)
        {
            List<SelectListItem> list = new List<SelectListItem>();
            var invItems =  _repo.GetAllAsync();
            var invItem = invItems.Where(x => x.Id == Id).FirstOrDefault();
            if (invItem != null)
            {
                list.Add(new SelectListItem() { Value = Id.ToString(), Text = invItem.Name });
            }
            foreach (var item in invItems)
            {
                if (item.Id != Id)
                {
                    list.Add(new SelectListItem() { Value = item.Id.ToString(), Text = item.Name });
                }
            }
            return list;
        }
        public IEnumerable<SelectListItem> getMeasuringUnitList(IMeasuringUnitRepository _repo, long? Id)
        {
            List<SelectListItem> list = new List<SelectListItem>();
            var mUnits =  _repo.GetAllAsync();
            var mUnit = mUnits.Where(x => x.Id == Id).FirstOrDefault();
            if (mUnit != null)
            {
                list.Add(new SelectListItem() { Value = Id.ToString(), Text = mUnit.Name });
            }
            foreach (var item in mUnits)
            {
                if (item.Id != Id)
                {
                    list.Add(new SelectListItem() { Value = item.Id.ToString(), Text = item.Name });
                }
            }
            return list;
        }
    }
}
