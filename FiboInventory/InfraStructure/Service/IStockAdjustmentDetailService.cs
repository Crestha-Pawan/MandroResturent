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
    
    public interface IStockAdjustmentDetailService
    {
        Task<StockAdjustmentDetailDto> InsertAsync(StockAdjustmentDetailDto dto);
        Task<StockAdjustmentDetail> Delete(long Id);
        Task<StockAdjustmentDetailDto> UpdateAsync(StockAdjustmentDetailDto dto);
    }
    public class StockAdjustmentDetailService : IStockAdjustmentDetailService
    {
        private readonly IStockAdjustmentDetailRepository _repo;
        private readonly IStockAdjustmentDetailAssembler _assembler;
        public StockAdjustmentDetailService(IStockAdjustmentDetailRepository repo, IStockAdjustmentDetailAssembler assembler)
        {
            _repo = repo;
            _assembler = assembler;
        }

        public async Task<StockAdjustmentDetail> Delete(long Id)
        {
            var sa = await _repo.GetByIdAsync(Id) ?? throw new Exception();
            return await _repo.DeleteAsync(sa).ConfigureAwait(true);
        }

        public async Task<StockAdjustmentDetailDto> InsertAsync(StockAdjustmentDetailDto dto)
        {
            StockAdjustmentDetail sa = new StockAdjustmentDetail();
            _assembler.copyTo(sa, dto);
            await _repo.AddAsync(sa);
            dto.Id = sa.Id;
            return dto;
        }

        public async Task<StockAdjustmentDetailDto> UpdateAsync(StockAdjustmentDetailDto dto)
        {
            StockAdjustmentDetail sa = new StockAdjustmentDetail();
            _assembler.modifyTo(sa, dto);
            await _repo.UpdateAsync(sa);
            return dto;
        }
    }
}
