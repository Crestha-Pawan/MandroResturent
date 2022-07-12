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
    public interface IRoomSetupService
    {
        Task<RoomSetupDto> InsertAsync(RoomSetupDto dto);
        Task<RoomSetup> Delete(long Id);
        Task<RoomSetupDto> UpdateAsync(RoomSetupDto dto);
        Task<RoomCheckInDto> UpdateFromCheckInAsync(RoomCheckInDto dto, string status);
    }
    public class RoomSetupService : IRoomSetupService
    {
        private readonly IRoomSetupRepository _repo;
        private readonly IRoomSetupAssembler _assembler;
        private readonly IRoomSetupService _service;
        public RoomSetupService(IRoomSetupRepository repo, IRoomSetupAssembler assembler)
        {
            _repo = repo;
            _assembler = assembler;
        }

        public async Task<RoomSetup> Delete(long Id)
        {
            var room = await _repo.GetByIdAsync(Id) ?? throw new Exception();
            return await _repo.DeleteAsync(room).ConfigureAwait(true);
        }

        public async Task<RoomSetupDto> InsertAsync(RoomSetupDto dto)
        {
            RoomSetup room = new RoomSetup();
            _assembler.copyTo(room, dto);
            await _repo.AddAsync(room);
            dto.Id = room.Id;
            return dto;
        }

        public async Task<RoomSetupDto> UpdateAsync(RoomSetupDto dto)
        {
            RoomSetup room = new RoomSetup();
            _assembler.modifyTo(room, dto);
            await _repo.UpdateAsync(room);
            return dto;
        }

        public async Task<RoomCheckInDto> UpdateFromCheckInAsync(RoomCheckInDto dto, string status)
        {
            if (dto.RoomSetupId.Contains(","))
            {
                string[] roomsetupId = dto.RoomSetupId.Split(",");
                for (int i = 0; i < roomsetupId.Length; i++)
                {
                    var room = await _repo.GetByIdAsync(long.Parse(roomsetupId[i])) ?? throw new Exception();
                    room.Status = status;
                    await _repo.UpdateAsync(room);
                }
            }
            else
            {
                var room = await _repo.GetByIdAsync(long.Parse(dto.RoomSetupId)) ?? throw new Exception();
                room.Status = status;
                await _repo.UpdateAsync(room);
            }
            return dto;
        }
    }
}
