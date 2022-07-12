using FiboInfraStructure.Entity.FiboInventory;
using FiboInventory.Src.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using FiboInfraStructure;
namespace FiboInventory.InfraStructure.Assembler
{
    
    public interface IStockAdjustmentAssembler
    {
        void copyTo(StockAdjustment stockAd, StockAdjustmentDto dto);
        void copyFrom(StockAdjustmentDto dto, StockAdjustment stockAd);
        void modifyTo(StockAdjustment stockAd, StockAdjustmentDto dto);
    }

    public class StockAdjustmentAssembler : IStockAdjustmentAssembler
    {
        public void copyFrom(StockAdjustmentDto dto, StockAdjustment stockAd)
        {
            dto.Id = stockAd.Id;
            dto.CreatedBy = stockAd.CreatedBy;
            dto.CreatedDate = stockAd.CreatedDate;
            dto.AdjustmentDate = stockAd.AdjustmentDate.ToNepDate();
            dto.AdjustedBy = stockAd.AdjustedBy;
            dto.BranchId = stockAd.BranchId;
        }

        public void copyTo(StockAdjustment stockAd, StockAdjustmentDto dto)
        {
            stockAd.CreatedBy = dto.CreatedBy;
            stockAd.CreatedDate = DateTime.Now;
            stockAd.AdjustmentDate = dto.AdjustmentDate.ToEnglishDate();
            stockAd.AdjustedBy = dto.AdjustedBy;
            stockAd.BranchId = dto.BranchId;
        }

        public void modifyTo(StockAdjustment stockAd, StockAdjustmentDto dto)
        {
            stockAd.Id = dto.Id;
            stockAd.CreatedBy = dto.CreatedBy;
            stockAd.CreatedDate = dto.CreatedDate;
            stockAd.ModifiedBy = dto.ModifiedBy;
            stockAd.ModifiedDate = DateTime.Now;
            stockAd.AdjustmentDate = dto.AdjustmentDate.ToEnglishDate();
            stockAd.AdjustedBy = dto.AdjustedBy;
            stockAd.BranchId = dto.BranchId;
        }
    }
}
