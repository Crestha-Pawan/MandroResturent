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
   
    public interface IVendorRepository : IRepository<Vendor>
    {
        Task<List<Vendor>> GetAllVendorAsync();
    }
    public class VendorRepository : Repository<Vendor>, IVendorRepository
    {
        public VendorRepository(ApplicationDbContext context) : base(context)
        {

        }

        public async Task<List<Vendor>> GetAllVendorAsync()
        {
            return await GetAllAsync().ToListAsync();
        }
    }
}
