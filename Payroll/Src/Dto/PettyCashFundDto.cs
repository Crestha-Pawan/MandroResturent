using System;
using System.Collections.Generic;
using System.Text;
using FiboInfraStructure.Src;

namespace Payroll.Src.Dto
{
   public class PettyCashFundDto : BaseDto
    {
        public string Date { get; set; }
        public string Amount { get; set; }
        public string Quantity { get; set; }
        public string Total { get; set; }
        public List<PettyCashFundDto> pettyCashFundDtos { get; set; }
    }
}
