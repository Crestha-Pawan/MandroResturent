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
   
    public interface ILodgeBillingRepository : IRepository<LodgeBilling>
    {
        Task<List<LodgeBilling>> GetAllLodgeBillingAsync();
    }
    public class LodgeBillingRepository : Repository<LodgeBilling>, ILodgeBillingRepository
    {
        public LodgeBillingRepository(ApplicationDbContext context) : base(context)
        {

        }

        public async Task<List<LodgeBilling>> GetAllLodgeBillingAsync()
        {
            return await GetAllAsync().ToListAsync();
        }
    }
}
