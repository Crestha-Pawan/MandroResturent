using FiboInfraStructure.Src;
using System;
using System.Collections.Generic;
using System.Text;

namespace FiboLodge.Src.Dto
{
    public class RoomSetupDto : BaseDto
    {
        public string RoomName { get; set; }
        public string Size { get; set; }
        public decimal ExtendedDuration { get; set; }
        public decimal ExtendedRate { get; set; }
        public decimal Duration { get; set; }
        public decimal Charges { get; set; }
        public string Status { get; set; }
    }
}
