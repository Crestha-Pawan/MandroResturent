using System;
using System.Collections.Generic;
using System.Text;

namespace FiboInfraStructure.Entity.Payroll
{
   public class OpeningClosing :BaseSetup
    {
        public string OpeningBalance { get; set; }
        public string ClosingBalance { get; set; }
        public string NetSaving { get; set; }
        public string Date { get; set; }
    }
}
