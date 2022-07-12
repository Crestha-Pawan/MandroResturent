using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using FiboInfraStructure.BaseInfraStructure;
using FiboInfraStructure.Data;
using FiboInfraStructure.Entity.Payroll;
using Microsoft.EntityFrameworkCore;

namespace FiboParty.Infrastructure.Repository
{
    public interface IPettyCashFundRepository : IRepository<PettyCashFund>
    {
        Task<List<PettyCashFund>> GetAllPettyCashFundAsync();
    }
    public class PettyCashFundRepository : Repository<PettyCashFund>, IPettyCashFundRepository
    {
        public PettyCashFundRepository(ApplicationDbContext context) : base(context)
        {

        }
        public async Task<List<PettyCashFund>> GetAllPettyCashFundAsync()
        {
            return await GetAllAsync().ToListAsync();
        }
    }
}
