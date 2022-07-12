using FiboInfraStructure.Entity.FiboInventory;
using FiboInventory.Src.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace FiboInventory.InfraStructure.Assembler
{
    
    public interface IStockAdjustmentDetailAssembler
    {
        void copyTo(StockAdjustmentDetail detail, StockAdjustmentDetailDto dto);
        void copyFrom(StockAdjustmentDetailDto dto, StockAdjustmentDetail detail);
        void modifyTo(StockAdjustmentDetail detail, StockAdjustmentDetailDto dto);
    }

    public class StockAdjustmentDetailAssembler : IStockAdjustmentDetailAssembler
    {
        public void copyFrom(StockAdjustmentDetailDto dto, StockAdjustmentDetail detail)
        {
            dto.Id = detail.Id;
            dto.CreatedBy = detail.CreatedBy;
            dto.CreatedDate = detail.CreatedDate;
            dto.ItemId = detail.ItemId;
            dto.MeasuringUnitId = detail.MeasuringUnitId;
            dto.Quantity = detail.Quantity;
            dto.StockAdjustmentId = detail.StockAdjustmentId;
        }

        public void copyTo(StockAdjustmentDetail detail, StockAdjustmentDetailDto dto)
        {
            detail.CreatedBy = dto.CreatedBy;
            detail.CreatedDate = DateTime.Now;
            detail.ItemId = dto.ItemId;
            detail.MeasuringUnitId = dto.MeasuringUnitId;
            detail.Quantity = dto.Quantity;
            detail.StockAdjustmentId = dto.StockAdjustmentId;
        }

        public void modifyTo(StockAdjustmentDetail detail, StockAdjustmentDetailDto dto)
        {
            detail.Id = dto.Id;
            detail.CreatedBy = dto.CreatedBy;
            detail.CreatedDate = dto.CreatedDate;
            detail.ModifiedBy = dto.ModifiedBy;
            detail.ModifiedDate = DateTime.Now;
            detail.ItemId = dto.ItemId;
            detail.MeasuringUnitId = dto.MeasuringUnitId;
            detail.Quantity = dto.Quantity;
            detail.StockAdjustmentId = dto.StockAdjustmentId;
        }
    }
}
