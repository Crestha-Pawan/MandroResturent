using System;
using System.Collections.Generic;
using System.Text;

namespace FiboInfraStructure.Entity.FiboBilling
{
    public class Notification : BaseEntity
    {
        public bool IsKOTActive()
        {
            return IsKOT = true;
        }

        public bool IsBOTActive()
        {
            return IsKOT == false;
        }
        public bool IsChecked{ get; set; }
        public bool IsKOT { get; set; }
    }
}
