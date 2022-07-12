using System;
using System.Collections.Generic;
using System.Text;
using FiboInfraStructure.Enums;
namespace FiboInfraStructure.Entity.FiboLodge
{
    public class RoomSetup: BaseCounterEntity
    {
        private readonly string StatusVacantClean = FiboInfraStructure.Enums.Status.VacantClean.ToString();
        private readonly string StatusEngaged = FiboInfraStructure.Enums.Status.Engaged.ToString();
        private readonly string StatusVacantDirty = FiboInfraStructure.Enums.Status.VacantDirty.ToString();
        private readonly string StatusReserved = FiboInfraStructure.Enums.Status.Reserved.ToString();
        public bool IsVacantClean()
        {
            return Status == StatusVacantClean;
        }

        public bool IsEngaged()
        {
            return Status == StatusEngaged;
        }
        public bool IsVacantDirty()
        {
            return Status == StatusVacantDirty;
        }
        public bool IsReserved()
        {
            return Status == StatusReserved;
        }
        public void VacantClean()
        {
            Status = StatusVacantClean;
        }

        public void Engaged()
        {
            Status = StatusEngaged;
        }
        public void VacantDirty()
        {
            Status = StatusVacantDirty;
        }

        public void Reserved()
        {
            Status = StatusReserved;
        }
        public string RoomName { get; set; }
        public string Size { get; set; }
        public decimal Duration { get; set; }
        public decimal ExtendedDuration { get; set; }
        public decimal ExtendedRate { get; set; }
        public decimal Charges { get; set; }
        public string Status { get; set; }
    }
}
