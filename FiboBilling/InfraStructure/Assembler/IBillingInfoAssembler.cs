using FiboBilling.Src.Dto;
using FiboInfraStructure.Entity.FiboBilling;
using System;
using System.Collections.Generic;
using System.Text;

namespace FiboBilling.InfraStructure.Assembler
{

    public interface IBillingInfoAssembler
    {
        void copyTo(BillingInfo billing, BillingInfoDto dto);
        void copyFrom(BillingInfoDto dto, BillingInfo billing);
        void modifyTo(BillingInfo billing, BillingInfoDto dto);
    }

    public class BillingInfoAssembler : IBillingInfoAssembler
    {
        public void copyFrom(BillingInfoDto dto, BillingInfo billing)
        {
            dto.Id = billing.Id;
            dto.CreatedBy = billing.CreatedBy;
            dto.CreatedDate = billing.CreatedDate;
            dto.ProductId = billing.ProductId;
            dto.Rate = billing.Rate;
            dto.Price = billing.Price;
            dto.Quantity = billing.Quantity;
            dto.Amount = billing.Amount;
            dto.Remarks = billing.Remarks;
            dto.BillingId = billing.BillingId;
            dto.IsTakeAway = billing.IsTakeAway;
            dto.TakeAwayQuantity = billing.TakeAwayQuantity;
            dto.Order = billing.Order;
        }

        public void copyTo(BillingInfo billing, BillingInfoDto dto)
        {
            billing.CreatedBy = dto.CreatedBy;
            billing.CreatedDate = DateTime.Now;
            billing.ProductId = dto.ProductId;
            billing.Rate = dto.Rate;
            billing.Price = dto.Price.Value;
            billing.Quantity = dto.Quantity;
            billing.Amount = dto.Amount;
            billing.Remarks = dto.Remarks;
            billing.BillingId = dto.BillingId;
            billing.IsKOT = dto.IsKOT;
            billing.IsTakeAway = dto.IsTakeAway;
            billing.TakeAwayQuantity = dto.TakeAwayQuantity;
            billing.Order = dto.Order;
        }

        public void modifyTo(BillingInfo billing, BillingInfoDto dto)
        {
            billing.Id = dto.Id;
            billing.CreatedBy = dto.CreatedBy;
            billing.CreatedDate = dto.CreatedDate;
            billing.ModifiedBy = dto.ModifiedBy;
            billing.ModifiedDate = DateTime.Now;
            billing.ProductId = dto.ProductId;
            billing.Rate = dto.Rate;
            billing.Price = dto.Price.Value;
            billing.Quantity = dto.Quantity;
            billing.Amount = dto.Amount;
            billing.Remarks = dto.Remarks;
            billing.BillingId = dto.BillingId;
            billing.Order = dto.Order;
        }
    }
}
