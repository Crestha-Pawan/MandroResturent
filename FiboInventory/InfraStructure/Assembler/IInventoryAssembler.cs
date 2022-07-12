using FiboInfraStructure;
using FiboInfraStructure.Entity.FiboInventory;
using FiboInventory.Src.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace FiboInventory.InfraStructure.Assembler
{
    
    public interface IInventoryAssembler
    {
        void copyTo(Inventory inv, InventoryDto dto);
        void copyFrom(InventoryDto dto, Inventory inv);
        void modifyTo(Inventory inv, InventoryDto dto);
    }

    public class InventoryAssembler : IInventoryAssembler
    {
        public void copyFrom(InventoryDto dto, Inventory inv)
        {
            dto.Id = inv.Id;
            dto.CreatedBy = inv.CreatedBy;
            dto.CreatedDate = inv.CreatedDate;
            dto.ItemId = inv.ItemId;
            dto.Date = inv.Date.ToNepDate();
            dto.Quantity = inv.Quantity;
            dto.ActualQuantity = inv.ActualQuantity;
            dto.AvailableQuantity = inv.AvailableQuantity;
            dto.ConsumedQuantity = inv.ConsumedQuantity;
            dto.Rate = inv.Rate;
            dto.Total = inv.Total;
            dto.VendorId = inv.VendorId;

        }

        public void copyTo(Inventory inv, InventoryDto dto)
        {
            inv.CreatedBy = dto.CreatedBy;
            inv.CreatedDate = DateTime.Now;
            inv.ItemId = dto.ItemId;
            inv.Date= dto.Date.ToEnglishDate();
            inv.Quantity = dto.Quantity;
            inv.ActualQuantity = dto.Quantity.ToDecimal();
            inv.AvailableQuantity = dto.Quantity.ToDecimal();
            inv.ConsumedQuantity = dto.ConsumedQuantity;
            inv.Rate = dto.Rate;
            inv.Total = dto.Total;
            inv.VendorId = dto.VendorId;
        }

        public void modifyTo(Inventory inv, InventoryDto dto)
        {
            inv.Id = dto.Id;
            inv.CreatedBy = dto.CreatedBy;
            inv.CreatedDate = dto.CreatedDate;
            inv.ModifiedBy = dto.ModifiedBy;
            inv.ModifiedDate = DateTime.Now;
            inv.Date = dto.Date.ToEnglishDate();
            inv.ItemId = dto.ItemId;
            inv.Quantity = dto.Quantity;
            inv.ActualQuantity = dto.ActualQuantity;
            inv.AvailableQuantity = dto.AvailableQuantity;
            inv.ConsumedQuantity = dto.ConsumedQuantity;
            inv.Rate = dto.Rate;
            inv.Total = dto.Total;
            inv.VendorId = dto.VendorId;
        }
    }
}
