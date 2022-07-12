using FiboInfraStructure.Entity.FiboOffice;
using FiboOffice.Src.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace FiboOffice.InfraStructure.Assembler
{

    public interface ITaxAssembler
    {
        void copyTo(Tax tax, TaxDto dto);
        void copyFrom(TaxDto dto, Tax tax);
        void modifyTo(Tax tax, TaxDto dto);
    }

    public class TaxAssembler : ITaxAssembler
    {
        public void copyFrom(TaxDto dto, Tax tax)
        {
            dto.Id = tax.Id;
            dto.CreatedBy = tax.CreatedBy;
            dto.CreatedDate = tax.CreatedDate;
            dto.Name = tax.Name;
            dto.TaxPercent = tax.TaxPercent;
            dto.Status = tax.Status;
        }

        public void copyTo(Tax tax, TaxDto dto)
        {
            tax.CreatedBy = dto.CreatedBy;
            tax.CreatedDate = DateTime.Now;
            tax.Name = dto.Name;
            tax.TaxPercent = dto.TaxPercent;
            tax.Activate();
        }

        public void modifyTo(Tax tax, TaxDto dto)
        {
            tax.Id = dto.Id;
            tax.CreatedBy = dto.CreatedBy;
            tax.CreatedDate = dto.CreatedDate;
            tax.ModifiedBy = dto.ModifiedBy;
            tax.ModifiedDate = DateTime.Now;
            tax.Name = dto.Name;
            tax.TaxPercent = dto.TaxPercent;
            tax.Status = dto.Status;
        }
    }
}
