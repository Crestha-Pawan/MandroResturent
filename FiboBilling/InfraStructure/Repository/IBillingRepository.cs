using FiboInfraStructure.BaseInfraStructure;
using FiboInfraStructure.Data;
using FiboInfraStructure.Entity.FiboBilling;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiboBilling.InfraStructure.Repository
{

    public interface IBillingRepository : IRepository<Billing>
    {
        Task<List<Billing>> GetAllBillingAsync();
        IQueryable<Billing> GetAllBillings();
        IQueryable<Billing> GetAllBillingsByFilter(string searchString);
        Task<List<Billing>> GetWaitingBills();
        Task<List<Billing>> GetClearBills();
        Task<Billing> GetWaitingByTableId(long id);
    }
    public class BillingRepository : Repository<Billing>, IBillingRepository
    {
        public BillingRepository(ApplicationDbContext context) : base(context)
        {

        }

        public async Task<List<Billing>> GetAllBillingAsync()
        {
            return await GetAllAsync().ToListAsync();
        }

        public IQueryable<Billing> GetAllBillings()
        {
            return GetAllAsync();
        }

        public IQueryable<Billing> GetAllBillingsByFilter(string searchString=null)
        {
            return GetAllAsync().Where(x =>
                x.GuestName.ToString().Contains(searchString) ||
                x.PaymentMethod.ToString().Contains(searchString));
        }

        public async Task<List<Billing>> GetClearBills()
        {
            return await GetAllAsync().Where(x => x.IsWaiting()).ToListAsync();
        }

        public async Task<List<Billing>> GetWaitingBills()
        {
            return await GetAllAsync().Where(x => x.IsWaiting()).ToListAsync();
        }

        public async Task<Billing> GetWaitingByTableId(long id)
        {
            return await GetAllAsync().Where(x => x.IsWaiting() && x.TableId == id).FirstOrDefaultAsync();
        }
    }
}
