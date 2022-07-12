using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using FiboInfraStructure.BaseInfraStructure;
using FiboInfraStructure.Data;
using FiboInfraStructure.Entity.FiboOffice;
using Microsoft.EntityFrameworkCore;

namespace FiboOffice.InfraStructure.Repository
{
   public interface IMeasuringUnitRepository : IRepository<MeasuringUnit>
    {
        Task<List<MeasuringUnit>> GetAllMeasuringUnitAsync();
    }
    public class MeasuringUnitRepository : Repository<MeasuringUnit>, IMeasuringUnitRepository
    {
        public MeasuringUnitRepository(ApplicationDbContext context) : base(context)
        {

        }

        public async Task<List<MeasuringUnit>> GetAllMeasuringUnitAsync()
        {
            return await GetAllAsync().ToListAsync();
        }
    }
}
