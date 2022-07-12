using FiboBilling.InfraStructure.Assembler;
using FiboBilling.InfraStructure.Repository;
using FiboBilling.Src.Dto;
using FiboInfraStructure;
using FiboInfraStructure.Data;
using FiboInfraStructure.Entity.FiboBilling;
using FiboInventory.InfraStructure.Repository;
using FiboInventory.InfraStructure.Service;
using FiboOffice.InfraStructure.Repository;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiboBilling.InfraStructure.Service
{

    public interface IBillingService
    {
        Task<BillingDto> InsertAsync(BillingDto dto);
        Task<Billing> Delete(long Id);
        Task<BillingDto> UpdateAsync(BillingDto dto);
    }
    public class BillingService : IBillingService
    {
        private readonly IBillingRepository _repo;
        private readonly IBillingAssembler _assembler;
        private readonly IBillingInfoService _billingInfoService;
        private readonly ITaxRepository _taxRepo;
        private readonly IServiceChargeRepository _scRepo;

        public BillingService(IBillingRepository repo
            , IBillingAssembler assembler
            , IBillingInfoService billingInfoService
            , ITaxRepository taxRepo
            , IServiceChargeRepository scRepo
        )
        {
            _repo = repo;
            _assembler = assembler;
            _billingInfoService = billingInfoService;
            _taxRepo = taxRepo;
            _scRepo = scRepo;
        }

        public async Task<Billing> Delete(long Id)
        {
            var billing = await _repo.GetByIdAsync(Id) ?? throw new Exception();
            return await _repo.DeleteAsync(billing).ConfigureAwait(true);
        }

        public async Task<BillingDto> InsertAsync(BillingDto dto)
        {
            try
            {
                Billing billing = new Billing();
                _assembler.copyTo(billing, dto);
                if (dto.IsClear)
                {
                    billing.clear();
                }
                await _repo.AddAsync(billing);
                dto.Id = billing.Id;

                if (dto.BillingInfo.Count > 0)
                {
                    await _billingInfoService.SaveAndDelete(dto);
                }
                return dto;
            }
            catch (Exception ex)
            {
                throw new Exception($"Billing with {dto.Id} not found.");
            }
        }

        public async Task<BillingDto> UpdateAsync(BillingDto dto)
        {
            try
            {
                var billing = await _repo.GetByIdAsync(dto.Id) ?? throw new Exception();
                _assembler.modifyTo(billing, dto);
                if (dto.IsClear)
                {
                    billing.clear();
                }
                await _repo.UpdateAsync(billing);
                dto.Id = billing.Id;

                if (dto.BillingInfo?.Count > 0)
                {
                    await _billingInfoService.SaveAndDelete(dto);
                }
                return dto;
            }
            catch (Exception ex)
            {
                throw new Exception($"Billing with {dto.Id} not found.");
            }
        }
    }
}
