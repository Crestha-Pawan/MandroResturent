using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using FiboInfraStructure.Entity.FiboBilling;
using FiboInfraStructure.Entity.FiboOffice;

namespace FiboBilling.Src.ViewModel
{
    public class BillingReportViewModel
    {
        public List<BillingInfo> BillingInfoList { get; set; }
        public List<Billing> Billings { get; set; }
        public string Name { get; set; }
        [NotMapped]
        public DateTime? FromDate { get; set; }
        [NotMapped]
        public DateTime? ToDate { get; set; }
        [NotMapped]
        public string FromMiti { get; set; }
        [NotMapped]
        public string ToMiti { get; set; }
        public string PaymentMethod { get; set; }

    }
}
