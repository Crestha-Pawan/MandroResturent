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
   
    public interface ITableService
    {
        Task<TableDto> Insertasync(TableDto dto);
        Task<Table> Delete(long Id);
        Task<TableDto> UpdateAsync(TableDto dto);
    }
    public class TableService : ITableService
    {
        private readonly ITableRepository _repo;
        private readonly ITableAssembler _assembler;
        public TableService(ITableRepository repo, ITableAssembler assembler)
        {
            _repo = repo;
            _assembler = assembler;
        }

        public async Task<Table> Delete(long Id)
        {
            var table = await _repo.GetByIdAsync(Id) ?? throw new Exception();
            return await _repo.DeleteAsync(table).ConfigureAwait(true);
        }

        public async Task<TableDto> Insertasync(TableDto dto)
        {
            Table table = new Table();
            _assembler.copyTo(table, dto);
            await _repo.AddAsync(table);
            dto.Id = table.Id;
            return dto;
        }

        public async Task<TableDto> UpdateAsync(TableDto dto)
        {
            Table table = new Table();
            _assembler.modifyTo(table, dto);
            await _repo.UpdateAsync(table);
            return dto;
        }
    }
}
