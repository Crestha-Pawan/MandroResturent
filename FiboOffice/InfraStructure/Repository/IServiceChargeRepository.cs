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
    
    public interface IServiceChargeRepository : IRepository<ServiceCharge>
    {
        Task<List<ServiceCharge>> GetAllServiceChargeAsync();
    }
    public class ServiceChargeRepository : Repository<ServiceCharge>, IServiceChargeRepository
    {
        public ServiceChargeRepository(ApplicationDbContext context) : base(context)
        {

        }

        public async Task<List<ServiceCharge>> GetAllServiceChargeAsync()
        {
            return await GetAllAsync().ToListAsync();
        }
    }
}
