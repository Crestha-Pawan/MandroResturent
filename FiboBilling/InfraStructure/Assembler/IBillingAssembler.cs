using FiboBilling.Src.Dto;
using FiboInfraStructure.Entity.FiboBilling;
using System;
using System.Collections.Generic;
using System.Text;

namespace FiboBilling.InfraStructure.Assembler
{

    public interface IBillingAssembler
    {
        void copyTo(Billing billing, BillingDto dto);
        void copyFrom(BillingDto dto, Billing billing);
        void modifyTo(Billing billing, BillingDto dto);
    }

    public class BillingAssembler : IBillingAssembler
    {
        public void copyFrom(BillingDto dto, Billing billing)
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
            dto.TableId = billing.TableId;
            dto.Status = billing.Status;
            dto.ServiceCharge = billing.ServiceCharge;
            dto.TaxAmount = billing.TaxAmount;
            dto.NetAmtPayable = billing.NetAmtPayable;
            dto.KotBotBy = billing.KotBotBy;
        }

        public void copyTo(Billing billing, BillingDto dto)
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
            billing.TableId = dto.TableId;
            billing.TableNo = dto.TableNo;
            billing.ServiceCharge = dto.ServiceCharge;
            billing.TaxAmount = dto.TaxAmount;
            billing.NetAmtPayable = dto.NetAmtPayable;
            billing.KotBotBy = dto.KotBotBy;
            billing.wait();
        }

        public void modifyTo(Billing billing, BillingDto dto)
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
            billing.TableId = dto.TableId;
            billing.TableNo = dto.TableNo;
            billing.ServiceCharge = dto.ServiceCharge;
            billing.TaxAmount = dto.TaxAmount;
            billing.NetAmtPayable = dto.NetAmtPayable;
            billing.KotBotBy = dto.KotBotBy;
            if (!billing.IsCancelled())
            {
                billing.wait();
            }
            else
            {
                billing.Status = dto.Status;
            }
        }
    }
}
