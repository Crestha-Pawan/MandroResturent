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
    
    public interface IStockAdjustmentService
    {
        Task<StockAdjustmentDto> InsertAsync(StockAdjustmentDto dto);
        Task<StockAdjustment> Delete(long Id);
        Task<StockAdjustmentDto> UpdateAsync(StockAdjustmentDto dto);
    }
    public class StockAdjustmentService : IStockAdjustmentService
    {
        private readonly IStockAdjustmentRepository _repo;
        private readonly IStockAdjustmentAssembler _assembler;
        private readonly IStockAdjustmentDetailService _stockAdjustmentDetailService;
        public StockAdjustmentService(IStockAdjustmentRepository repo
            , IStockAdjustmentDetailService stockAdjustmentDetailService
            , IStockAdjustmentAssembler assembler)
        {
            _repo = repo;
            _stockAdjustmentDetailService = stockAdjustmentDetailService;
            _assembler = assembler;
        }

        public async Task<StockAdjustment> Delete(long Id)
        {
            var sa = await _repo.GetByIdAsync(Id) ?? throw new Exception();
            return await _repo.DeleteAsync(sa).ConfigureAwait(true);
        }

        public async Task<StockAdjustmentDto> InsertAsync(StockAdjustmentDto dto)
        {
            StockAdjustment sa = new StockAdjustment();
            _assembler.copyTo(sa, dto);
            await _repo.AddAsync(sa);
            dto.Id = sa.Id;
            if (dto.StockAdjustmentDetailDtos.Count > 0)
            {
                foreach (var dto_info in dto.StockAdjustmentDetailDtos)
                {
                    dto_info.StockAdjustmentId = dto.Id;
                    dto_info.CreatedBy = dto.CreatedBy;
                    dto_info.BranchId = dto.BranchId;
                    await _stockAdjustmentDetailService.InsertAsync(dto_info);
                }
            }
            return dto;
        }

        public async Task<StockAdjustmentDto> UpdateAsync(StockAdjustmentDto dto)
        {
            StockAdjustment sa = new StockAdjustment();
            _assembler.modifyTo(sa, dto);
            await _repo.UpdateAsync(sa);
            return dto;
        }
    }
}
