using FiboInfraStructure.Entity.FiboLodge;
using FiboLodge.Src.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace FiboLodge.InfraStructure.Assembler
{
    public interface IRoomCheckInAssembler
    {
        void copyTo(RoomCheckIn room, RoomCheckInDto dto);
        void copyFrom(RoomCheckInDto dto, RoomCheckIn room);
        void modifyTo(RoomCheckIn room, RoomCheckInDto dto);
    }

    public class RoomCheckInAssembler : IRoomCheckInAssembler
    {
        public void copyFrom(RoomCheckInDto dto, RoomCheckIn room)
        {
            dto.Id = room.Id;
            dto.CreatedBy = room.CreatedBy;
            dto.CreatedDate = room.CreatedDate;
            dto.BranchId = room.BranchId;
            dto.CustomerName = room.CustomerName;
            dto.Address = room.Address;
            dto.ContactNo = room.ContactNo;
            dto.TotalPerson = room.TotalPerson;
            dto.Duration = room.Duration;
            dto.Advance = room.Advance;
            dto.RoomSetupId = room.RoomSetupId;
            dto.Status = room.Status;
        }

        public void copyTo(RoomCheckIn room, RoomCheckInDto dto)
        {
            room.CreatedBy = dto.CreatedBy;
            room.CreatedDate = DateTime.Now;
            room.BranchId = dto.BranchId;
            room.CustomerName = dto.CustomerName;
            room.Address = dto.Address;
            room.ContactNo = dto.ContactNo;
            room.TotalPerson = dto.TotalPerson;
            room.Duration = dto.Duration;
            room.Advance = dto.Advance;
            room.RoomSetupId = dto.RoomSetupId;
            room.CheckIn();
        }

        public void modifyTo(RoomCheckIn room, RoomCheckInDto dto)
        {
            room.Id = dto.Id;
            room.CreatedBy = dto.CreatedBy;
            room.CreatedDate = dto.CreatedDate;
            room.ModifiedBy = dto.ModifiedBy;
            room.ModifiedDate = DateTime.Now;
            room.BranchId = dto.BranchId;
            room.CustomerName = dto.CustomerName;
            room.Address = dto.Address;
            room.ContactNo = dto.ContactNo;
            room.TotalPerson = dto.TotalPerson;
            room.Duration = dto.Duration;
            room.Advance = dto.Advance;
            room.RoomSetupId = dto.RoomSetupId;
            room.Status = dto.Status;
        }
    }
}
