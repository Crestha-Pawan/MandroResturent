using FiboBilling.InfraStructure.Assembler;
using FiboBilling.InfraStructure.Repository;
using FiboBilling.Src.Dto;
using FiboInfraStructure.Entity.FiboBilling;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FiboBilling.InfraStructure.Service
{
    public interface ILodgeBillingService
    {
        Task<LodgeBillingDto> InsertAsync(LodgeBillingDto dto);
        Task<LodgeBilling> Delete(long Id);
        Task<LodgeBillingDto> UpdateAsync(LodgeBillingDto dto);
    }
    public class LodgeBillingService : ILodgeBillingService
    {
        private readonly ILodgeBillingRepository _repo;
        private readonly ILodgeBillingAssembler _assembler;

        public LodgeBillingService(ILodgeBillingRepository repo
            , ILodgeBillingAssembler assembler
        )
        {
            _repo = repo;
            _assembler = assembler;
        }

        public async Task<LodgeBilling> Delete(long Id)
        {
            var billing = await _repo.GetByIdAsync(Id) ?? throw new Exception();
            return await _repo.DeleteAsync(billing).ConfigureAwait(true);
        }

        public async Task<LodgeBillingDto> InsertAsync(LodgeBillingDto dto)
        {
            try
            {
                LodgeBilling billing = new LodgeBilling();
                _assembler.copyTo(billing, dto);
                
                await _repo.AddAsync(billing);
                dto.Id = billing.Id;
                return dto;
            }
            catch (Exception ex)
            {
                throw new Exception($"Billing with {dto.Id} not found.");
            }
        }

        public async Task<LodgeBillingDto> UpdateAsync(LodgeBillingDto dto)
        {
            try
            {
                LodgeBilling billing = new LodgeBilling();
                _assembler.modifyTo(billing, dto);
                
                await _repo.UpdateAsync(billing);
                dto.Id = billing.Id;

                return dto;
            }
            catch (Exception ex)
            {
                throw new Exception($"Billing with {dto.Id} not found.");
            }
        }
    }
}
