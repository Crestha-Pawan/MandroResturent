using FiboInfraStructure.Entity.FiboOffice;
using FiboOffice.Src.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace FiboOffice.InfraStructure.Assembler
{
    public interface IDayCashBookAssembler
    {
        void copyTo(DayCashBook dayCashBook, DayCashBookDto dto);
        void copyFrom(DayCashBookDto dto, DayCashBook dayCashBook);
        void modifyTo(DayCashBook dayCashBook, DayCashBookDto dto);
    }

    public class DayCashBookAssembler : IDayCashBookAssembler
    {
        public void copyFrom(DayCashBookDto dto, DayCashBook dayCashBook)
        {
            dto.Id = dayCashBook.Id;
            dto.CreatedBy = dayCashBook.CreatedBy;
            dto.CreatedDate = dayCashBook.CreatedDate;
            dto.OpeningDate = dayCashBook.OpeningDate;
            dto.OpeningBalance = dayCashBook.OpeningBalance;
        }

        public void copyTo(DayCashBook dayCashBook, DayCashBookDto dto)
        {
            dayCashBook.CreatedBy = dto.CreatedBy;
            dayCashBook.CreatedDate = DateTime.Now;
            dayCashBook.OpeningDate = dto.OpeningDate;
            dayCashBook.OpeningBalance = dto.OpeningBalance;
        }

        public void modifyTo(DayCashBook dayCashBook, DayCashBookDto dto)
        {
            dayCashBook.Id = dto.Id;
            dayCashBook.CreatedBy = dto.CreatedBy;
            dayCashBook.CreatedDate = dto.CreatedDate;
            dayCashBook.ModifiedBy = dto.ModifiedBy;
            dayCashBook.ModifiedDate = DateTime.Now;
            dayCashBook.OpeningDate = dto.OpeningDate;
            dayCashBook.OpeningBalance = dto.OpeningBalance;
        }
    }
}
