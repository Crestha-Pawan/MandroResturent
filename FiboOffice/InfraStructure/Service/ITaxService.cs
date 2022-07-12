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
    public interface ITaxService
    {
        Task<TaxDto> InsertAsync(TaxDto dto);
        Task<Tax> Delete(long Id);
        Task<TaxDto> UpdateAsync(TaxDto dto);
        Task<Tax> ToggleStatus(Tax tax);
    }
    public class TaxService : ITaxService
    {
        private readonly ITaxRepository _repo;
        private readonly ITaxAssembler _assembler;
        public TaxService(ITaxRepository repo, ITaxAssembler assembler)
        {
            _repo = repo;
            _assembler = assembler;
        }

        public async Task<Tax> Delete(long Id)
        {
            var tax = await _repo.GetByIdAsync(Id) ?? throw new Exception();
            return await _repo.DeleteAsync(tax).ConfigureAwait(true);
        }

        public async Task<TaxDto> InsertAsync(TaxDto dto)
        {
            Tax tax = new Tax();
            _assembler.copyTo(tax, dto);
            await _repo.AddAsync(tax);
            dto.Id = tax.Id;
            return dto;
        }

        public async Task<TaxDto> UpdateAsync(TaxDto dto)
        {
            Tax tax = new Tax();
            _assembler.modifyTo(tax, dto);
            await _repo.UpdateAsync(tax);
            return dto;
        }
        public async Task<Tax> ToggleStatus(Tax tax)
        {
            if (tax != null)
            {
                tax.ChangeStatus();
            }
            return await _repo.UpdateAsync(tax).ConfigureAwait(true);
        }
    }
}
