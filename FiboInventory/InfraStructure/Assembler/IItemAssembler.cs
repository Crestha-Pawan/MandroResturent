using FiboInfraStructure.Entity.FiboInventory;
using FiboInventory.Src.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace FiboInventory.InfraStructure.Assembler
{
    public interface IItemAssembler
    {
        void copyTo(Item item, ItemDto dto);
        void copyFrom(ItemDto dto, Item item);
        void modifyTo(Item item, ItemDto dto);
    }

    public class ItemAssembler : IItemAssembler
    {
        public void copyFrom(ItemDto dto, Item item)
        {
            dto.Id = item.Id;
            dto.CreatedBy = item.CreatedBy;
            dto.CreatedDate = item.CreatedDate;
            dto.Name = item.Name;
            dto.MeasuringUnitId = item.MeasuringUnitId;
        }

        public void copyTo(Item item, ItemDto dto)
        {
            item.CreatedBy = dto.CreatedBy;
            item.CreatedDate = DateTime.Now;
            item.Name = dto.Name;
            item.MeasuringUnitId = dto.MeasuringUnitId;
        }

        public void modifyTo(Item item, ItemDto dto)
        {
            item.Id = dto.Id;
            item.CreatedBy = dto.CreatedBy;
            item.CreatedDate = dto.CreatedDate;
            item.ModifiedBy = dto.ModifiedBy;
            item.ModifiedDate = DateTime.Now;
            item.Name = dto.Name;
            item.MeasuringUnitId = dto.MeasuringUnitId;
        }
    }

}
