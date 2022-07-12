using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using FiboInfraStructure.Entity.FiboOffice;
using FiboOffice.InfraStructure.Assembler;
using FiboOffice.InfraStructure.Repository;
using FiboOffice.Src.Dto;

namespace FiboOffice.InfraStructure.Service
{
   public interface IMeasuringUnitService
    {
        Task<MeasuringUnitDto> Insertasync(MeasuringUnitDto dto);
        Task<MeasuringUnit> Delete(long Id);
        Task<MeasuringUnitDto> UpdateAsync(MeasuringUnitDto dto);
    }

    public class MeasuringUnitService : IMeasuringUnitService
    {
        private readonly IMeasuringUnitRepository _measuringUnitRepository;
        private readonly IMeasuringUnitAssembler _assembler;
        public MeasuringUnitService(IMeasuringUnitRepository measuringUnitRepository, IMeasuringUnitAssembler  assembler)
        {
            _measuringUnitRepository = measuringUnitRepository;
            _assembler = assembler;
        }
        public async Task<MeasuringUnitDto> Insertasync(MeasuringUnitDto dto)
        {
            MeasuringUnit measuringUnit = new MeasuringUnit();
            _assembler.copyTo(measuringUnit, dto);
            await _measuringUnitRepository.AddAsync(measuringUnit);
            dto.Id = measuringUnit.Id;
            return dto;
        }

        public async Task<MeasuringUnitDto> UpdateAsync(MeasuringUnitDto dto)
        {
            MeasuringUnit measuringUnit = new MeasuringUnit();
            _assembler.modifyTo(measuringUnit, dto);
            await _measuringUnitRepository.UpdateAsync(measuringUnit);
            return dto;
        }

        public async Task<MeasuringUnit> Delete(long Id)
        {
            var measuringUnit = await _measuringUnitRepository.GetByIdAsync(Id) ?? throw new Exception();
            return await _measuringUnitRepository.DeleteAsync(measuringUnit).ConfigureAwait(true);
        }

    }
}
