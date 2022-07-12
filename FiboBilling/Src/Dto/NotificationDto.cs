using FiboInfraStructure.Src;
using System;
using System.Collections.Generic;
using System.Text;

namespace FiboBilling.Src.Dto
{
    public class NotificationDto: BaseDto
    {
        public bool IsChecked { get; set; }
        public bool IsKOT { get; set; }
    }
}
