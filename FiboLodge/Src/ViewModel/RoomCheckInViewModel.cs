using FiboInfraStructure.Entity.FiboLodge;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace FiboLodge.Src.ViewModel
{
    public class RoomCheckInViewModel
    {
        public List<RoomCheckIn> RoomCheckInList { get; set; }
        public List<RoomSetup> RoomSetupList { get; set; }
        public string RoomSetupId { get; set; }
        public IList<RoomSetup> RoomSetups { get; set; } = new List<RoomSetup>();
        public SelectList RoomSetupSelectList => new SelectList(RoomSetups, nameof(RoomSetup.Id), nameof(RoomSetup.RoomName));
    }
}
