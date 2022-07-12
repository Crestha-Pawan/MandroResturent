using System;
using System.Collections.Generic;
using System.Text;
using FiboInfraStructure.Entity.Payroll;
using Payroll.Src.Dto;

namespace Payroll.InfraStructure.Assembler
{
   public interface IOpeningClosingAssembler
    {
        void copyTo(OpeningClosing openingClosing, OpeningClosingDto dto);
        void copyFrom(OpeningClosingDto dto, OpeningClosing openingClosing);
        void modifyTo(OpeningClosing openingClosing, OpeningClosingDto dto);
    }
    public class OpeningClosingAssembler : IOpeningClosingAssembler
    {
        public void copyFrom(OpeningClosingDto dto, OpeningClosing openingClosing)
        {
            dto.Id = openingClosing.Id;
           dto.CreatedBy = openingClosing.CreatedBy;
            dto.CreatedDate = openingClosing.CreatedDate;
            openingClosing.Date = dto.Date;
            openingClosing.OpeningBalance = dto.OpeningBalance;
            openingClosing.ClosingBalance = dto.ClosingBalance;
            openingClosing.NetSaving = dto.NetSaving;

        }

        public void copyTo(OpeningClosing openingClosing, OpeningClosingDto dto)
        {
               dto.Id = openingClosing.Id;
            dto.Date = openingClosing.Date;
            dto.OpeningBalance = openingClosing.OpeningBalance;
            dto.ClosingBalance = openingClosing.ClosingBalance;
            dto.NetSaving = openingClosing.NetSaving;
            openingClosing.CreatedBy = dto.CreatedBy;
            openingClosing.CreatedDate = DateTime.Now;
           
        }

        public void modifyTo(OpeningClosing openingClosing, OpeningClosingDto dto)
        {
            openingClosing.Id = dto.Id;
            openingClosing.CreatedBy = dto.CreatedBy;
            openingClosing.Date = dto.Date;
            openingClosing.OpeningBalance = dto.OpeningBalance;
            openingClosing.ClosingBalance = dto.ClosingBalance;
            openingClosing.NetSaving = dto.NetSaving;
            openingClosing.CreatedDate = DateTime.Now;
            openingClosing.ModifiedBy = dto.ModifiedBy;
            openingClosing.ModifiedDate = DateTime.Now;
            
        }
    }
}
