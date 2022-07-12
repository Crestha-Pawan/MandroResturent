using FiboInfraStructure.Entity.FiboOffice;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FiboInfraStructure.Entity.FiboBilling
{
    public class Billing : BaseCounterEntity
    {
        private readonly string StatusClear = "Clear";
        private readonly string StatusWaiting = "Waiting";
        private readonly string CreditPaymentMethod = "Credit";
        private readonly string StatusCancelled = "Cancelled";
        public void clear()
        {
            Status = StatusClear;
        }

        public void wait()
        {
            Status = StatusWaiting;
        }

        public void cancel()
        {
            Status = StatusCancelled;
        }

        public bool IsClear()
        {
            return Status == StatusClear;
        }

        public bool IsWaiting()
        {
            return Status == StatusWaiting;
        }

        public bool IsCancelled()
        {
            return Status == StatusCancelled;
        }
        public bool IsCredit()
        {
            return PaymentMethod == CreditPaymentMethod;
        }
        public DateTime? BillingDate { get; set; }
        public string BillingNumber { get; set; }
        public decimal Discount { get; set; }
        public decimal Total { get; set; }
        public long? FiscalYearId { get; set; }
        public string GuestName { get; set; }
        public string KotBotBy { get; set; }

        public string TableNo { get; set; }
     
        public string PaymentMethod { get; set; }
        public string Status { get; set; }
        public virtual FiscalYear FiscalYear { get; set; }

        [ForeignKey("TableId")]
        public long? TableId { get; set; }

        public decimal ServiceCharge { get; set; }
        public long? ServiceChargeId { get; set; }
        public long? TaxId { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal NetAmtPayable { get; set; }
        [NotMapped()]
        public virtual Table Table { get; set; }
    }
}
