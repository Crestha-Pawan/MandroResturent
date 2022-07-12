using FiboInfraStructure.Entity.FiboOffice;
using FiboOffice.InfraStructure.Assembler;
using FiboOffice.InfraStructure.Repository;
using FiboOffice.Src.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FiboOffice.InfraStructure.Service
{
    
    public interface IServiceChargeService
    {
        Task<ServiceChargeDto> InsertAsync(ServiceChargeDto dto);
        Task<ServiceCharge> Delete(long Id);
        Task<ServiceChargeDto> UpdateAsync(ServiceChargeDto dto);
        Task<ServiceCharge> ToggleStatus(ServiceCharge sc);
    }
    public class ServiceChargeService : IServiceChargeService
    {
        private readonly IServiceChargeRepository _repo;
        private readonly IServiceChargeAssembler _assembler;
        public ServiceChargeService(IServiceChargeRepository repo, IServiceChargeAssembler assembler)
        {
            _repo = repo;
            _assembler = assembler;
        }

        public async Task<ServiceCharge> Delete(long Id)
        {
            var sc = await _repo.GetByIdAsync(Id) ?? throw new Exception();
            return await _repo.DeleteAsync(sc).ConfigureAwait(true);
        }

        public async Task<ServiceChargeDto> InsertAsync(ServiceChargeDto dto)
        {
            ServiceCharge sc = new ServiceCharge();
            _assembler.copyTo(sc, dto);
            await _repo.AddAsync(sc);
            dto.Id = sc.Id;
            return dto;
        }

        public async Task<ServiceChargeDto> UpdateAsync(ServiceChargeDto dto)
        {
            ServiceCharge sc = new ServiceCharge();
            _assembler.modifyTo(sc, dto);
            await _repo.UpdateAsync(sc);
            return dto;
        }
        public async Task<ServiceCharge> ToggleStatus(ServiceCharge sc)
        {
            if (sc != null)
            {
                sc.ChangeStatus();
            }
            return await _repo.UpdateAsync(sc).ConfigureAwait(true);
        }
    }
}
