using FiboInfraStructure.Entity.FiboLodge;
using FiboInfraStructure.Src;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FiboLodge.Src.Dto
{
    public class RoomCheckInDto : BaseDto
    {
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string ContactNo { get; set; }
        public string TotalPerson { get; set; }
        public decimal Duration { get; set; }
        public decimal Advance { get; set; }
        [NotMapped]
        public string[] RoomList { get; set; }
        public string RoomSetupId { get; set; }
        public string Status { get; set; }
        public IList<RoomSetup> RoomSetups { get; set; } = new List<RoomSetup>();
        public SelectList RoomSetupList => new SelectList(RoomSetups, nameof(RoomSetup.Id), nameof(RoomSetup.RoomName));
    }
}
