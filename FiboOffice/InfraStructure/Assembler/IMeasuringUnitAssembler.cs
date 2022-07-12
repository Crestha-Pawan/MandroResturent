using System;
using System.Collections.Generic;
using System.Text;
using FiboInfraStructure.Entity.FiboOffice;
using FiboOffice.Src.Dto;

namespace FiboOffice.InfraStructure.Assembler
{
   public interface IMeasuringUnitAssembler
    {
        void copyTo(MeasuringUnit measuringUnit, MeasuringUnitDto dto);
        void copyFrom(MeasuringUnitDto dto, MeasuringUnit measuringUnit);
        void modifyTo(MeasuringUnit measuringUnit, MeasuringUnitDto dto);
    }
    public class MeasuringUnitAssembler : IMeasuringUnitAssembler
    {
        //copy to entity(table)
        public void copyTo(MeasuringUnit measuringUnit, MeasuringUnitDto dto)
        {
            measuringUnit.CreatedBy = dto.CreatedBy;
            measuringUnit.CreatedDate = DateTime.Now;
            measuringUnit.Name = dto.Name;
        }
        //copy from entity(table)
        public void copyFrom(MeasuringUnitDto dto, MeasuringUnit measuringUnit)
        {
            dto.Id = measuringUnit.Id;
            dto.CreatedBy = measuringUnit.CreatedBy;
            dto.CreatedDate = measuringUnit.CreatedDate;
            dto.Name = measuringUnit.Name;
        }

        //modified to entity(table)
        public void modifyTo(MeasuringUnit measuringUnit, MeasuringUnitDto dto)
        {
            measuringUnit.Id = dto.Id;
            measuringUnit.CreatedBy = dto.CreatedBy;
            measuringUnit.CreatedDate = DateTime.Now;
            measuringUnit.ModifiedBy = dto.ModifiedBy;
            measuringUnit.ModifiedDate = DateTime.Now;
            measuringUnit.Name = dto.Name;
        }
    }
}
