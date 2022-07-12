using FiboInfraStructure.Src;
using System;
using System.Collections.Generic;
using System.Text;

namespace FiboBilling.Src.Dto
{
    public class BillingInfoDto : BaseDto
    {
        public long? BillingId { get; set; }
        public long? Rate { get; set; }
        public long? Quantity { get; set; }
        public long? ProductId { get; set; }
        public decimal Amount { get; set; }
        public string Remarks { get; set; }
        public string Order { get; set; }
        public decimal? Price { get; set; }
        public bool IsKOT { get; set; }
        public bool IsTakeAway { get; set; }
        public string TakeAwayQuantity { get; set; }
    }
}
