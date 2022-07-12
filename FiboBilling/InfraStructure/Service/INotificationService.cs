using FiboBilling.InfraStructure.Assembler;
using FiboBilling.InfraStructure.Repository;
using FiboBilling.Src.Dto;
using FiboInfraStructure.Entity.FiboBilling;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FiboBilling.InfraStructure.Service
{
    
    public interface INotificationService
    {
        Task<NotificationDto> InsertAsync(NotificationDto dto);
        Task<Notification> Delete(long Id);
        Task<NotificationDto> UpdateAsync(NotificationDto dto);
    }
    public class NotificationService : INotificationService
    {
        private readonly INotificationRepository _repo;
        private readonly INotificationAssembler _assembler;
        

        public NotificationService(INotificationRepository repo
            , INotificationAssembler assembler
        )
        {
            _repo = repo;
            _assembler = assembler;
        }
        public async Task<Notification> Delete(long Id)
        {
            var notification = await _repo.GetByIdAsync(Id) ?? throw new Exception();
            return await _repo.DeleteAsync(notification).ConfigureAwait(true);
        }

        public async Task<NotificationDto> InsertAsync(NotificationDto dto)
        {
            try
            {
                Notification notification = new Notification();
                _assembler.copyTo(notification, dto);
                
                await _repo.AddAsync(notification);
                dto.Id = notification.Id;
                return dto;
            }
            catch (Exception ex)
            {
                throw new Exception($"Notification with {dto.Id} not found.");
            }

        }

        public async Task<NotificationDto> UpdateAsync(NotificationDto dto)
        {
            try
            {
                Notification notification = new Notification();
                _assembler.modifyTo(notification, dto);
                
                await _repo.UpdateAsync(notification);
                dto.Id = notification.Id;
                return dto;
            }
            catch (Exception ex)
            {
                throw new Exception($"Notification with {dto.Id} not found.");
            }
        }
    }
}
