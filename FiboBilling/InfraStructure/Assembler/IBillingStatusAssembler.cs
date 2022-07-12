using FiboBilling.Src.Dto;
using FiboInfraStructure.Entity.FiboBilling;
using System;
using System.Collections.Generic;
using System.Text;

namespace FiboBilling.InfraStructure.Assembler
{
    public interface IBillingStatusAssembler
    {
        void copyTo(BillingStatus billingStatus, BillingStatusDto dto);
            void copyFrom(BillingStatusDto dto, BillingStatus billingStatus);
        void modifyTo(BillingStatus billingStatus, BillingStatusDto dto);
    }
    public class BillingStatusAssembler : IBillingStatusAssembler
    {
        public void copyFrom(BillingStatusDto dto, BillingStatus billingStatus)
        {
            dto.Id= billingStatus.Id;
            dto.BillingId= billingStatus.BillingId;
            dto.ModifiedBy= billingStatus.ModifiedBy;
            dto.CreatedBy= billingStatus.CreatedBy;
            dto.CreatedDate =billingStatus.CreatedDate;
            dto.IsPaid= billingStatus.IsPaid;
        }

        public void copyTo(BillingStatus billingStatus, BillingStatusDto dto)
        {
            billingStatus.BillingId = dto.BillingId;
            billingStatus.IsPaid = dto.IsPaid;
            billingStatus.CreatedBy = dto.CreatedBy;
            billingStatus.CreatedDate = dto.CreatedDate;
            billingStatus.ModifiedDate = dto.ModifiedDate;
            billingStatus.ModifiedBy = dto.ModifiedBy;
        }

        public void modifyTo(BillingStatus billingStatus, BillingStatusDto dto)
        {
            billingStatus.Id = dto.Id;
            billingStatus.BillingId = dto.BillingId;
            billingStatus.IsPaid = dto.IsPaid;
            billingStatus.CreatedBy = dto.CreatedBy;
            billingStatus.CreatedDate = dto.CreatedDate;
            billingStatus.ModifiedDate = dto.ModifiedDate;
            billingStatus.ModifiedBy = dto.ModifiedBy;
        }
    }
}
