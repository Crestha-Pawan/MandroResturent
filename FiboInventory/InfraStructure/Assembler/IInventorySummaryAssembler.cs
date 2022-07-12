using FiboInfraStructure.Entity.FiboInventory;
using FiboInventory.Src.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace FiboInventory.InfraStructure.Assembler
{
    
    public interface IInventorySummaryAssembler
    {
        void copyTo(InventorySummary invSummary, InventorySummaryDto dto);
        void copyFrom(InventorySummaryDto dto, InventorySummary invSummary);
        void modifyTo(InventorySummary invSummary, InventorySummaryDto dto);
    }

    public class InventorySummaryAssembler : IInventorySummaryAssembler
    {
        public void copyFrom(InventorySummaryDto dto, InventorySummary invSummary)
        {
            dto.Id = invSummary.Id;
            dto.CreatedBy = invSummary.CreatedBy;
            dto.CreatedDate = invSummary.CreatedDate;
            dto.StockDate = invSummary.StockDate;
            dto.InventoryId = invSummary.InventoryId;
            dto.StockInHand = invSummary.StockInHand;
            dto.AddedStock = invSummary.AddedStock;
            dto.ClosingStock = invSummary.ClosingStock;
            dto.PurchasePrice = invSummary.PurchasePrice;
        }

        public void copyTo(InventorySummary invSummary, InventorySummaryDto dto)
        {
            invSummary.CreatedBy = dto.CreatedBy;
            invSummary.CreatedDate = DateTime.Now;
            invSummary.StockDate = DateTime.Now;
            invSummary.InventoryId = dto.InventoryId;
            invSummary.StockInHand = dto.StockInHand;
            invSummary.AddedStock = dto.AddedStock;
            invSummary.ClosingStock = dto.ClosingStock;
            invSummary.PurchasePrice = dto.PurchasePrice;
        }

        public void modifyTo(InventorySummary invSummary, InventorySummaryDto dto)
        {
            invSummary.Id = dto.Id;
            invSummary.CreatedBy = dto.CreatedBy;
            invSummary.CreatedDate = dto.CreatedDate;
            invSummary.ModifiedBy = dto.ModifiedBy;
            invSummary.ModifiedDate = DateTime.Now;
            invSummary.StockDate = dto.StockDate;
            invSummary.InventoryId = dto.InventoryId;
            invSummary.StockInHand = dto.StockInHand;
            invSummary.AddedStock = dto.AddedStock;
            invSummary.ClosingStock = dto.ClosingStock;
            invSummary.PurchasePrice = dto.PurchasePrice;
        }
    }
}
