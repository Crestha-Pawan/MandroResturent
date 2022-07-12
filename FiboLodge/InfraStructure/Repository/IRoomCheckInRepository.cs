using FiboInfraStructure.BaseInfraStructure;
using FiboInfraStructure.Data;
using FiboInfraStructure.Entity.FiboLodge;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FiboLodge.InfraStructure.Repository
{
    
    public interface IRoomCheckInRepository : IRepository<RoomCheckIn>
    {
        Task<List<RoomCheckIn>> GetAllRoomCheckInAsync();
    }
    public class RoomCheckInRepository : Repository<RoomCheckIn>, IRoomCheckInRepository
    {
        public RoomCheckInRepository(ApplicationDbContext context) : base(context)
        {

        }

        public async Task<List<RoomCheckIn>> GetAllRoomCheckInAsync()
        {
            return await GetAllAsync().ToListAsync();
        }
    }
}
