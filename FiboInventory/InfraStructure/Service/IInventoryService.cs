using FiboInfraStructure;
using FiboInfraStructure.Entity.FiboInventory;
using FiboInventory.InfraStructure.Assembler;
using FiboInventory.InfraStructure.Repository;
using FiboInventory.Src.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiboInventory.InfraStructure.Service
{

    public interface IInventoryService
    {
        Task<InventoryDto> Insertasync(InventoryDto dto);
        Task<Inventory> Delete(long Id);
        Task<InventoryDto> UpdateAsync(InventoryDto dto);
        Task<InventorySummaryDto> UpdateFromSummaryAsync(InventorySummaryDto dto);
        Task<InventoryDto> UpdateFromBillingAsync(long id, decimal quantity);
    }
    public class InventoryService : IInventoryService
    {
        private readonly IInventoryRepository _repo;
        private readonly IInventoryAssembler _assembler;
        public InventoryService(IInventoryRepository repo, IInventoryAssembler assembler)
        {
            _repo = repo;
            _assembler = assembler;
        }

        public async Task<Inventory> Delete(long Id)
        {
            var inv = await _repo.GetByIdAsync(Id) ?? throw new Exception();
            return await _repo.DeleteAsync(inv).ConfigureAwait(true);
        }

        public async Task<InventoryDto> Insertasync(InventoryDto dto)
        {
            Inventory inv = new Inventory();
            _assembler.copyTo(inv, dto);
            await _repo.AddAsync(inv);
            dto.Id = inv.Id;
            return dto;
        }

        public async Task<InventoryDto> UpdateAsync(InventoryDto dto)
        {
            Inventory inv = new Inventory();
            _assembler.modifyTo(inv, dto);
            await _repo.UpdateAsync(inv);
            return dto;
        }

        public async Task<InventoryDto> UpdateFromBillingAsync(long id, decimal quantity)
        {
            var invList = await _repo.GetAllInventoryAsync();
            var inv = invList.Where(x=>x.ItemId==id).FirstOrDefault();
            InventoryDto inv_dto = new InventoryDto();
            _assembler.copyFrom(inv_dto, inv);
            inv_dto.ConsumedQuantity = inv.ConsumedQuantity + quantity;
            inv_dto.AvailableQuantity = inv.AvailableQuantity - quantity;
            _assembler.modifyTo(inv, inv_dto);
            await _repo.UpdateAsync(inv);
            return inv_dto;
        }

        public async Task<InventorySummaryDto> UpdateFromSummaryAsync(InventorySummaryDto dto)
        {
            var inv = await _repo.GetByIdAsync((long)dto.InventoryId);
            InventoryDto inv_dto = new InventoryDto();
            _assembler.copyFrom(inv_dto, inv);
            //inv_dto.Quantity = (inv.Quantity.ToDecimal() + dto.AddedStock).ToString();
            inv_dto.Quantity = (inv.Quantity.ToDecimal()).ToString();
            inv_dto.ActualQuantity = inv.ActualQuantity + dto.AddedStock;
            _assembler.modifyTo(inv, inv_dto);
            await _repo.UpdateAsync(inv);
            return dto;
        }
        
    }
}
