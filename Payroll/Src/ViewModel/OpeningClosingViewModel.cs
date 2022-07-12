using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using FiboInfraStructure.Entity.Payroll;

namespace Payroll.Src.ViewModel
{
   public class OpeningClosingViewModel
    {
        public List<OpeningClosing> OpenignClosing { get; set; }

        [NotMapped]
        public DateTime? FromDate { get; set; }
        [NotMapped]
        public DateTime? ToDate { get; set; }
        [NotMapped]
        public string FromMiti { get; set; }
        [NotMapped]
        public string ToMiti { get; set; }
    }
}
