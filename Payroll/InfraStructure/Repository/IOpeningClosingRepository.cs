using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using FiboInfraStructure.BaseInfraStructure;
using FiboInfraStructure.Data;
using FiboInfraStructure.Entity.Payroll;
using Microsoft.EntityFrameworkCore;

namespace Payroll.InfraStructure.Repository
{
   public interface IOpeningClosingRepository : IRepository<OpeningClosing>
    {
        Task<List<OpeningClosing>> GetAllOpeningClosingAsync();
    }
    public class OpeningClosingRepository : Repository<OpeningClosing>, IOpeningClosingRepository
    {
        public OpeningClosingRepository(ApplicationDbContext context) : base(context)
        {

        }
        public async Task<List<OpeningClosing>> GetAllOpeningClosingAsync()
        {
            return await GetAllAsync().ToListAsync();
        }
    }
}
