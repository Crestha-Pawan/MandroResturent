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
    
    public interface INotificationRepository : IRepository<Notification>
    {
        Task<List<Notification>> GetAllNotificationAsync();
       
    }
    public class NotificationRepository : Repository<Notification>, INotificationRepository
    {
        public NotificationRepository(ApplicationDbContext context) : base(context)
        {

        }

        public async Task<List<Notification>> GetAllNotificationAsync()
        {
            return await GetAllAsync().ToListAsync();
        }
    }
}
