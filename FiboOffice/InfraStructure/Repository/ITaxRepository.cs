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
    
    public interface ITaxRepository : IRepository<Tax>
    {
        Task<List<Tax>> GetAllTaxAsync();
    }
    public class TaxRepository : Repository<Tax>, ITaxRepository
    {
        public TaxRepository(ApplicationDbContext context) : base(context)
        {

        }

        public async Task<List<Tax>> GetAllTaxAsync()
        {
            return await GetAllAsync().ToListAsync();
        }
    }
}
