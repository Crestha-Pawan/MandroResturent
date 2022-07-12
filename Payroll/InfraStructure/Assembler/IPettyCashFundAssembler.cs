using System;
using System.Collections.Generic;
using System.Text;
using FiboInfraStructure.Entity.Payroll;
using Payroll.Src.Dto;

namespace Payroll.InfraStructure.Assembler
{
   public interface IPettyCashFundAssembler
    {
        void copyTo(PettyCashFund pettyCashFund, PettyCashFundDto dto);
        void copyFrom(PettyCashFundDto dto, PettyCashFund pettyCashFund);
        void modifyTo(PettyCashFund pettyCashFund, PettyCashFundDto dto);
    }
    public class PettyCashFundAssembler : IPettyCashFundAssembler
    {
        //copy to entity(table)
        public void copyTo(PettyCashFund pettyCashFund, PettyCashFundDto dto)
        {
            pettyCashFund.CreatedBy = dto.CreatedBy;
            pettyCashFund.CreatedDate = DateTime.Now;
            pettyCashFund.Date = dto.Date;
            pettyCashFund.Amount = dto.Amount;
            pettyCashFund.Quantity = dto.Quantity;
            pettyCashFund.Total = dto.Total;
        }
        //copy from entity(table)
        public void copyFrom(PettyCashFundDto dto, PettyCashFund pettyCashFund)
        {
            dto.CreatedBy = pettyCashFund.CreatedBy;
            dto.CreatedDate = pettyCashFund.CreatedDate;
            dto.Id = pettyCashFund.Id;
            dto.Date = pettyCashFund.Date;
            dto.Amount = pettyCashFund.Amount;
            dto.Quantity = pettyCashFund.Quantity;
            dto.Total = pettyCashFund.Total;
        }

        //modified to entity(table)
        public void modifyTo(PettyCashFund pettyCashFund, PettyCashFundDto dto)
        {
            pettyCashFund.Id = dto.Id;
            pettyCashFund.ModifiedBy = dto.ModifiedBy;
            pettyCashFund.ModifiedDate = DateTime.Now;
            pettyCashFund.CreatedDate = dto.CreatedDate;
            pettyCashFund.Date = dto.Date;
            pettyCashFund.Amount = dto.Amount;
            pettyCashFund.Quantity = dto.Quantity;
            pettyCashFund.Total = dto.Total;
        }
    }
}
