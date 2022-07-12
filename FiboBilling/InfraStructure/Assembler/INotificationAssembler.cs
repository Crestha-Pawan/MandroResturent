using FiboBilling.Src.Dto;
using FiboInfraStructure.Entity.FiboBilling;
using System;
using System.Collections.Generic;
using System.Text;

namespace FiboBilling.InfraStructure.Assembler
{

    public interface INotificationAssembler
    {
        void copyTo(Notification billing, NotificationDto dto);
        void copyFrom(NotificationDto dto, Notification billing);
        void modifyTo(Notification billing, NotificationDto dto);
    }

    public class NotificationAssembler : INotificationAssembler
    {
        public void copyFrom(NotificationDto dto, Notification billing)
        {
            dto.Id = billing.Id;
            dto.IsChecked = billing.IsChecked;
            dto.IsKOT = billing.IsKOT;
        }

        public void copyTo(Notification billing, NotificationDto dto)
        {
            billing.CreatedBy = dto.CreatedBy;
            billing.CreatedDate = DateTime.Now;
            billing.IsChecked = dto.IsChecked;
            billing.IsKOT = dto.IsKOT;
        }

        public void modifyTo(Notification billing, NotificationDto dto)
        {
            billing.Id = dto.Id;
            billing.CreatedBy = dto.CreatedBy;
            billing.IsChecked = dto.IsChecked;
            billing.CreatedDate = DateTime.Now;
            billing.ModifiedBy = dto.ModifiedBy;
            billing.ModifiedDate = DateTime.Now;
            billing.IsKOT = dto.IsKOT;
        }
    }
}
