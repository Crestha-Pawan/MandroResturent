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
   
    public interface IVendorService
    {
        Task<VendorDto> InsertAsync(VendorDto dto);
        Task<Vendor> Delete(long Id);
        Task<VendorDto> UpdateAsync(VendorDto dto);
        Task<Vendor> ToggleStatus(Tax tax);
    }
    public class VendorService : IVendorService
    {
        private readonly IVendorRepository _repo;
        private readonly IVendorAssembler _assembler;
        public VendorService(IVendorRepository repo, IVendorAssembler assembler)
        {
            _repo = repo;
            _assembler = assembler;
        }

        public async Task<Vendor> Delete(long Id)
        {
            var vendor = await _repo.GetByIdAsync(Id) ?? throw new Exception();
            return await _repo.DeleteAsync(vendor).ConfigureAwait(true);
        }

        public async Task<VendorDto> InsertAsync(VendorDto dto)
        {
            Vendor vendor = new Vendor();
            _assembler.copyTo(vendor, dto);
            await _repo.AddAsync(vendor);
            dto.Id = vendor.Id;
            return dto;
        }

        public Task<Vendor> ToggleStatus(Tax tax)
        {
            throw new NotImplementedException();
        }

        public async Task<VendorDto> UpdateAsync(VendorDto dto)
        {
            Vendor vendor = new Vendor();
            _assembler.modifyTo(vendor, dto);
            await _repo.UpdateAsync(vendor);
            return dto;
        }
    }
}
