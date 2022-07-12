using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using FiboInfraStructure.Entity.Payroll;
using Payroll.InfraStructure.Assembler;
using Payroll.InfraStructure.Repository;
using Payroll.Src.Dto;

namespace Payroll.InfraStructure.Service
{
   public interface IOpeningClosingService
    {
        Task<OpeningClosingDto> Insertasync(OpeningClosingDto dto);
        Task<OpeningClosing> Delete(long Id);
        Task<OpeningClosingDto> UpdateAsync(OpeningClosingDto dto);
    }
    public class OpeningClosingService : IOpeningClosingService
    {
        private readonly IOpeningClosingRepository _openingclosingRepository;
        private readonly IOpeningClosingAssembler _assembler;
        public OpeningClosingService(IOpeningClosingRepository openingclosingRepository,
            IOpeningClosingAssembler assembler
           
            )
        {
            _openingclosingRepository = openingclosingRepository;
            _assembler = assembler;
        }
        public async Task<OpeningClosingDto> Insertasync(OpeningClosingDto dto)
        {
            OpeningClosing openingClosing = new OpeningClosing();
            _assembler.copyTo(openingClosing, dto);
            await _openingclosingRepository.AddAsync(openingClosing);
            dto.Id = openingClosing.Id;

            return dto;
        }

        public async Task<OpeningClosingDto> UpdateAsync(OpeningClosingDto dto)
        {
            OpeningClosing openingClosing  = new OpeningClosing();
            _assembler.modifyTo(openingClosing, dto);
            await _openingclosingRepository.UpdateAsync(openingClosing);
            return dto;
        }

        public async Task<OpeningClosing> Delete(long Id)
        {
            var openingclosing = await _openingclosingRepository.GetByIdAsync(Id) ?? throw new Exception();
            return await _openingclosingRepository.DeleteAsync(openingclosing).ConfigureAwait(true);
        }

    }
}
