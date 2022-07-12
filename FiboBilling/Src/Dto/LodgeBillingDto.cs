using FiboInfraStructure.Src;
using System;
using System.Collections.Generic;
using System.Text;

namespace FiboBilling.Src.Dto
{
    public class LodgeBillingDto: BaseDto
    {
        public string RoomSetupId { get; set; }
        public DateTime? BillingDate { get; set; }
        public string BillingNumber { get; set; }
        public decimal Discount { get; set; }
        public decimal Total { get; set; }
        public long? FiscalYearId { get; set; }
        public string GuestName { get; set; }
        public string PaymentMethod { get; set; }
        public string Status { get; set; }
        public decimal ServiceCharge { get; set; }
        public long? ServiceChargeId { get; set; }
        public long? TaxId { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal NetAmtPayable { get; set; }
        public string Days { get; set; }
        public decimal Advance { get; set; }
    }
}
