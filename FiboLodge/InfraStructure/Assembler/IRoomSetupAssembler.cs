using FiboInfraStructure.Entity.FiboLodge;
using FiboLodge.Src.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace FiboLodge.InfraStructure.Assembler
{
    public interface IRoomSetupAssembler
    {
        void copyTo(RoomSetup room, RoomSetupDto dto);
        void copyFrom(RoomSetupDto dto, RoomSetup room);
        void modifyTo(RoomSetup room, RoomSetupDto dto);
    }

    public class RoomSetupAssembler : IRoomSetupAssembler
    {
        public void copyFrom(RoomSetupDto dto, RoomSetup room)
        {
            dto.Id = room.Id;
            dto.CreatedBy = room.CreatedBy;
            dto.CreatedDate = room.CreatedDate;
            dto.BranchId = room.BranchId;
            dto.RoomName = room.RoomName;
            dto.Size = room.Size;
            dto.Duration = room.Duration;
            dto.ExtendedDuration = room.ExtendedDuration;
            dto.ExtendedRate = room.ExtendedRate;
            dto.Charges = room.Charges;
            dto.Status = room.Status;
        }

        public void copyTo(RoomSetup room, RoomSetupDto dto)
        {
            room.CreatedBy = dto.CreatedBy;
            room.CreatedDate = DateTime.Now;
            room.BranchId = dto.BranchId;
            room.RoomName = dto.RoomName;
            room.Size = dto.Size;
            room.Duration = dto.Duration;
            room.ExtendedDuration = dto.ExtendedDuration;
            room.ExtendedRate = dto.ExtendedRate; 
            room.Charges = dto.Charges;
            room.VacantClean();
        }

        public void modifyTo(RoomSetup room, RoomSetupDto dto)
        {
            room.Id = dto.Id;
            room.CreatedBy = dto.CreatedBy;
            room.CreatedDate = dto.CreatedDate;
            room.ModifiedBy = dto.ModifiedBy;
            room.ModifiedDate = DateTime.Now;
            room.BranchId = dto.BranchId;
            room.RoomName = dto.RoomName;
            room.Size = dto.Size;
            room.Duration = dto.Duration;
            room.ExtendedDuration = dto.ExtendedDuration;
            room.ExtendedRate = dto.ExtendedRate;
            room.Charges = dto.Charges;
            room.Status = dto.Status;
        }
    }
}
