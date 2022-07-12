using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FiboInfraStructure.Entity.FiboLodge
{
    public class RoomCheckIn: BaseCounterEntity
    {
        private readonly string StatusActive = "Checked-In";
        private readonly string StatusInactive = "Checked-Out";

        public bool IsCheckIn()
        {
            return Status == StatusActive;
        }

        public bool IsCheckOut()
        {
            return Status == StatusInactive;
        }

        public void CheckIn()
        {
            Status = StatusActive;
        }

        public void CheckOut()
        {
            Status = StatusInactive;
        }

        public void ChangeStatus()
        {
            if (IsCheckIn())
            {
                CheckOut();
            }
            else
            {
                CheckIn();
            }
        }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string ContactNo { get; set; }
        public string TotalPerson { get; set; }
        public decimal Duration { get; set; }
        public decimal Advance { get; set; }
        public string RoomSetupId { get; set; }
        public string Status { get; set; }
    }
}
