using FiboInfraStructure.BaseInfraStructure;
using FiboInfraStructure.Data;
using FiboInfraStructure.Entity.FiboOffice;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FiboOffice.InfraStructure.Repository
{
    public interface IDayCashBookRepository : IRepository<DayCashBook>
    {
        Task<List<DayCashBook>> GetAllDayCashBookAsync();
    }
    public class DayCashBookRepository : Repository<DayCashBook>, IDayCashBookRepository
    {
        public DayCashBookRepository(ApplicationDbContext context) : base(context)
        {

        }

        public async Task<List<DayCashBook>> GetAllDayCashBookAsync()
        {
            return await GetAllAsync().ToListAsync();
        }
    }
}
