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
    public interface IDayCashBookService
    {
        Task<DayCashBookDto> InsertAsync(DayCashBookDto dto);
        Task<DayCashBook> Delete(long Id);
        Task<DayCashBookDto> UpdateAsync(DayCashBookDto dto);
    }
    public class DayCashBookService : IDayCashBookService
    {
        private readonly IDayCashBookRepository _repo;
        private readonly IDayCashBookAssembler _assembler;
        public DayCashBookService(IDayCashBookRepository repo, IDayCashBookAssembler assembler)
        {
            _repo = repo;
            _assembler = assembler;
        }

        public async Task<DayCashBook> Delete(long Id)
        {
            var dayCashBook = await _repo.GetByIdAsync(Id) ?? throw new Exception();
            return await _repo.DeleteAsync(dayCashBook).ConfigureAwait(true);
        }

        public async Task<DayCashBookDto> InsertAsync(DayCashBookDto dto)
        {
            DayCashBook dayCashBook = new DayCashBook();
            _assembler.copyTo(dayCashBook, dto);
            await _repo.AddAsync(dayCashBook);
            dto.Id = dayCashBook.Id;
            return dto;
        }

        public async Task<DayCashBookDto> UpdateAsync(DayCashBookDto dto)
        {
            DayCashBook dayCashBook = new DayCashBook();
            _assembler.modifyTo(dayCashBook, dto);
            await _repo.UpdateAsync(dayCashBook);
            return dto;
        }
    }
}
