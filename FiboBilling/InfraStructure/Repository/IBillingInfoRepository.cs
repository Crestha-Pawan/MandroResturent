using FiboInfraStructure.BaseInfraStructure;
using FiboInfraStructure.Data;
using FiboInfraStructure.Entity.FiboBilling;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace FiboBilling.InfraStructure.Repository
{

    public interface IBillingInfoRepository : IRepository<BillingInfo>
    {
        Task<List<BillingInfo>> GetAllBillingAsync();
        Task<List<BillingInfo>> GetByBillingId(long id);
    }
    public class BillingInfoRepository : Repository<BillingInfo>, IBillingInfoRepository
    {
        public BillingInfoRepository(ApplicationDbContext context) : base(context)
        {

        }

        public async Task<List<BillingInfo>> GetAllBillingAsync()
        {
            return await GetAllAsync().ToListAsync();
        }

        public async Task<List<BillingInfo>> GetByBillingId(long id)
        {
            return await GetAllAsync().Where(x => x.BillingId == id).ToListAsync();
        }
    }
}
