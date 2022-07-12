using FiboInfraStructure.BaseInfraStructure;
using FiboInfraStructure.Data;
using FiboInfraStructure.Entity.FiboInventory;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FiboInventory.InfraStructure.Repository
{
    public interface IInventoryRepository : IRepository<Inventory>
    {
        Task<List<Inventory>> GetAllInventoryAsync();
    }
    public class InventoryRepository : Repository<Inventory>, IInventoryRepository
    {
        public InventoryRepository(ApplicationDbContext context) : base(context)
        {

        }

        public async Task<List<Inventory>> GetAllInventoryAsync()
        {
            return await GetAllAsync().ToListAsync();
        }
    }
}
