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
  
    public interface IBillingStatusService
    {
        Task<BillingStatusDto> Insertasync(BillingStatusDto dto);
        Task<BillingStatus> Delete(long Id);
        Task<BillingStatusDto> UpdateAsync(BillingStatusDto dto);
    }
    public class BillingStatusService : IBillingStatusService
    {
        private readonly IBillingStatusRepository _repository;
        private readonly IBillingStatusAssembler _assembler;
        public BillingStatusService(IBillingStatusRepository repository, IBillingStatusAssembler assembler)
        {
            _repository = repository;
            _assembler = assembler;
        }
        public async Task<BillingStatus> Delete(long Id)
        {
            var billingstatus= await _repository.GetByIdAsync(Id) ?? throw new Exception();
            return await _repository.DeleteAsync(billingstatus).ConfigureAwait(true);
        }

       

        public async Task<BillingStatusDto> Insertasync(BillingStatusDto dto)
        {
            BillingStatus billingStatus = new BillingStatus();
            _assembler.copyTo(billingStatus, dto);
            await _repository.AddAsync(billingStatus);
            return dto;
        }
        public  async Task<BillingStatusDto> UpdateAsync(BillingStatusDto dto)
        {
            BillingStatus billingStatus = new BillingStatus();
            _assembler.modifyTo(billingStatus, dto);
            await _repository.UpdateAsync(billingStatus);
            return dto;
        }
    }
}
