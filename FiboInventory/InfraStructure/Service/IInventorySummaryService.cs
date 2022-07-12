using FiboInfraStructure.Entity.FiboInventory;
using FiboInventory.InfraStructure.Assembler;
using FiboInventory.InfraStructure.Repository;
using FiboInventory.Src.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FiboInventory.InfraStructure.Service
{
    
    public interface IInventorySummaryService
    {
        Task<InventorySummaryDto> Insertasync(InventorySummaryDto dto);
        Task<InventorySummary> Delete(long Id);
        Task<InventorySummaryDto> UpdateAsync(InventorySummaryDto dto);
    }
    public class InventorySummaryService : IInventorySummaryService
    {
        private readonly IInventorySummaryRepository _repo;
        private readonly IInventorySummaryAssembler _assembler;
        public InventorySummaryService(IInventorySummaryRepository repo, IInventorySummaryAssembler assembler)
        {
            _repo = repo;
            _assembler = assembler;
        }

        public async Task<InventorySummary> Delete(long Id)
        {
            var invSummary = await _repo.GetByIdAsync(Id) ?? throw new Exception();
            return await _repo.DeleteAsync(invSummary).ConfigureAwait(true);
        }

        public async Task<InventorySummaryDto> Insertasync(InventorySummaryDto dto)
        {
            InventorySummary invSummary = new InventorySummary();
            _assembler.copyTo(invSummary, dto);
            await _repo.AddAsync(invSummary);
            dto.Id = invSummary.Id;
            return dto;
        }

        public async Task<InventorySummaryDto> UpdateAsync(InventorySummaryDto dto)
        {
            InventorySummary invSummary = new InventorySummary();
            _assembler.modifyTo(invSummary, dto);
            await _repo.UpdateAsync(invSummary);
            return dto;
        }
    }
}
