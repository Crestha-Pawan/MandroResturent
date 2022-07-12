using FiboInfraStructure.BaseInfraStructure;
using FiboInfraStructure.Data;
using FiboInfraStructure.Entity.FiboBilling;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FiboBilling.InfraStructure.Repository
{
    
    public interface ITableRepository : IRepository<Table>
    {
        Task<List<Table>> GetAllTableAsync();
    }
    public class TableRepository : Repository<Table>, ITableRepository
    {
        public TableRepository(ApplicationDbContext context) : base(context)
        {

        }

        public async Task<List<Table>> GetAllTableAsync()
        {
            return await GetAllAsync().ToListAsync();
        }
    }
}
