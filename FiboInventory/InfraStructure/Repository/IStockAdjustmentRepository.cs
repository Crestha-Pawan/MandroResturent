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
    
    public interface IStockAdjustmentRepository : IRepository<StockAdjustment>
    {
        Task<List<StockAdjustment>> GetAllStockAdjustmentAsync();
    }
    public class StockAdjustmentRepository : Repository<StockAdjustment>, IStockAdjustmentRepository
    {
        public StockAdjustmentRepository(ApplicationDbContext context) : base(context)
        {

        }

        public async Task<List<StockAdjustment>> GetAllStockAdjustmentAsync()
        {
            return await GetAllAsync().ToListAsync();
        }
    }
}
