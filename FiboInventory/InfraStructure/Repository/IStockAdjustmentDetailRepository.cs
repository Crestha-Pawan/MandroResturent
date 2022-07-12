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
   
    public interface IStockAdjustmentDetailRepository : IRepository<StockAdjustmentDetail>
    {
        Task<List<StockAdjustmentDetail>> GetAllStockAdjustmentDetailAsync();
    }
    public class StockAdjustmentDetailRepository : Repository<StockAdjustmentDetail>, IStockAdjustmentDetailRepository
    {
        public StockAdjustmentDetailRepository(ApplicationDbContext context) : base(context)
        {

        }

        public async Task<List<StockAdjustmentDetail>> GetAllStockAdjustmentDetailAsync()
        {
            return await GetAllAsync().ToListAsync();
        }
    }
}
