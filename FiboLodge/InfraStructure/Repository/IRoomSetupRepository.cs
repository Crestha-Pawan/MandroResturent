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
    
    public interface IRoomSetupRepository : IRepository<RoomSetup>
    {
        Task<List<RoomSetup>> GetAllRoomAsync();
    }
    public class RoomSetupRepository : Repository<RoomSetup>, IRoomSetupRepository
    {
        public RoomSetupRepository(ApplicationDbContext context) : base(context)
        {

        }

        public async Task<List<RoomSetup>> GetAllRoomAsync()
        {
            return await GetAllAsync().ToListAsync();
        }
    }
}
