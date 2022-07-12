using FiboInfraStructure.Entity.FiboLodge;
using FiboLodge.InfraStructure.Assembler;
using FiboLodge.InfraStructure.Repository;
using FiboLodge.Src.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FiboLodge.InfraStructure.Service
{
    
    public interface IRoomCheckInService
    {
        Task<RoomCheckInDto> InsertAsync(RoomCheckInDto dto);
        Task<RoomCheckIn> Delete(long Id);
        Task<RoomCheckInDto> UpdateAsync(RoomCheckInDto dto);
        Task<RoomCheckIn> ToggleStatus(RoomCheckIn room);
    }
    public class RoomCheckInService : IRoomCheckInService
    {
        private readonly IRoomCheckInRepository _repo;
        private readonly IRoomCheckInAssembler _assembler;
        public RoomCheckInService(IRoomCheckInRepository repo, IRoomCheckInAssembler assembler)
        {
            _repo = repo;
            _assembler = assembler;
        }

        public async Task<RoomCheckIn> Delete(long Id)
        {
            var room = await _repo.GetByIdAsync(Id) ?? throw new Exception();
            return await _repo.DeleteAsync(room).ConfigureAwait(true);
        }

        public async Task<RoomCheckInDto> InsertAsync(RoomCheckInDto dto)
        {
            RoomCheckIn room = new RoomCheckIn();
            _assembler.copyTo(room, dto);
            await _repo.AddAsync(room);
            dto.Id = room.Id;
            return dto;
        }

        public async Task<RoomCheckInDto> UpdateAsync(RoomCheckInDto dto)
        {
            RoomCheckIn room = new RoomCheckIn();
            _assembler.modifyTo(room, dto);
            await _repo.UpdateAsync(room);
            return dto;
        }
        public async Task<RoomCheckIn> ToggleStatus(RoomCheckIn room)
        {
            if (room != null)
            {
                room.ChangeStatus();
            }
            return await _repo.UpdateAsync(room).ConfigureAwait(true);
        }
    }
}
