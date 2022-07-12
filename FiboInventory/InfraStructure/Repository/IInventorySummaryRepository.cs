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
    public interface IInventorySummaryRepository : IRepository<InventorySummary>
    {
        Task<List<InventorySummary>> GetAllInventorySummaryAsync();
    }
    public class InventorySummaryRepository : Repository<InventorySummary>, IInventorySummaryRepository
    {
        public InventorySummaryRepository(ApplicationDbContext context) : base(context)
        {

        }

        public async Task<List<InventorySummary>> GetAllInventorySummaryAsync()
        {
            return await GetAllAsync().ToListAsync();
        }
    }
}
