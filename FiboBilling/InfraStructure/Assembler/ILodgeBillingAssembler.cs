using FiboBilling.Src.Dto;
using FiboInfraStructure.Entity.FiboBilling;
using System;
using System.Collections.Generic;
using System.Text;

namespace FiboBilling.InfraStructure.Assembler
{
    public interface ILodgeBillingAssembler
    {
        void copyTo(LodgeBilling billing, LodgeBillingDto dto);
        void copyFrom(LodgeBillingDto dto, LodgeBilling billing);
        void modifyTo(LodgeBilling billing, LodgeBillingDto dto);
    }

    public class LodgeBillingAssembler : ILodgeBillingAssembler
    {
        public void copyFrom(LodgeBillingDto dto, LodgeBilling billing)
        {
            dto.Id = billing.Id;
            dto.GuestName = billing.GuestName;
            dto.PaymentMethod = billing.PaymentMethod;
            dto.CreatedBy = billing.CreatedBy;
            dto.CreatedDate = billing.CreatedDate;
            dto.BillingDate = billing.BillingDate;
            dto.BillingNumber = billing.BillingNumber;
            dto.FiscalYearId = billing.FiscalYearId;
            dto.Discount = billing.Discount;
            dto.Total = billing.Total;
            dto.Status = billing.Status;
            dto.ServiceCharge = billing.ServiceCharge;
            dto.TaxAmount = billing.TaxAmount;
            dto.NetAmtPayable = billing.NetAmtPayable;
            dto.RoomSetupId = billing.RoomSetupId;
            dto.Days = billing.Days;
            dto.Advance = billing.Advance;
        }

        public void copyTo(LodgeBilling billing, LodgeBillingDto dto)
        {
            billing.CreatedBy = dto.CreatedBy;
            billing.GuestName = dto.GuestName;
            billing.PaymentMethod = dto.PaymentMethod;
            billing.CreatedDate = DateTime.Now;
            billing.BillingDate = DateTime.Now;
            billing.BillingNumber = dto.BillingNumber;
            billing.FiscalYearId = dto.FiscalYearId;
            billing.Discount = dto.Discount;
            billing.Total = dto.Total;
            billing.ServiceCharge = dto.ServiceCharge;
            billing.TaxAmount = dto.TaxAmount;
            billing.NetAmtPayable = dto.NetAmtPayable;
            billing.RoomSetupId = dto.RoomSetupId;
            billing.Days = dto.Days;
            billing.Advance = dto.Advance;
        }

        public void modifyTo(LodgeBilling billing, LodgeBillingDto dto)
        {
            billing.Id = dto.Id;
            billing.CreatedBy = dto.CreatedBy;
            billing.GuestName = dto.GuestName;
            billing.PaymentMethod = dto.PaymentMethod;
            billing.CreatedDate = DateTime.Now;
            billing.ModifiedBy = dto.ModifiedBy;
            billing.ModifiedDate = DateTime.Now;
            billing.BillingDate = DateTime.Now;
            billing.BillingNumber = dto.BillingNumber;
            billing.FiscalYearId = dto.FiscalYearId;
            billing.Discount = dto.Discount;
            billing.Total = dto.Total;
            billing.ServiceCharge = dto.ServiceCharge;
            billing.TaxAmount = dto.TaxAmount;
            billing.NetAmtPayable = dto.NetAmtPayable;
            billing.RoomSetupId = dto.RoomSetupId;
            billing.Days = dto.Days;
            billing.Advance = dto.Advance;
        }
    }
}
