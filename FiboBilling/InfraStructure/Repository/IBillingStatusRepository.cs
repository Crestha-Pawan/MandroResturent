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
   
    public interface IBillingStatusRepository : IRepository<BillingStatus>
    {
        Task<List<BillingStatus>> GetAllBillingStatusAsync();
    }
    public class BillingStatusRepository : Repository<BillingStatus>, IBillingStatusRepository
    {
        public BillingStatusRepository(ApplicationDbContext context) : base(context)
        {

        }

        public async Task<List<BillingStatus>> GetAllBillingStatusAsync()
        {
            return await GetAllAsync().ToListAsync();
        }
    }
}
