using System;
using System.Collections.Generic;
using System.Text;
using FiboInfraStructure.Src;

namespace Payroll.Src.Dto
{
   public class OpeningClosingDto :BaseDto
    {
        public string OpeningBalance { get; set; }
        public string ClosingBalance { get; set; }
        public string NetSaving { get; set; }
        public string Date { get; set; }
    }
}
