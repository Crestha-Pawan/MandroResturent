using FiboInfraStructure.Entity.FiboOffice;
using FiboOffice.Src.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace FiboOffice.InfraStructure.Assembler
{
    
    public interface IServiceChargeAssembler
    {
        void copyTo(ServiceCharge sc, ServiceChargeDto dto);
        void copyFrom(ServiceChargeDto dto, ServiceCharge sc);
        void modifyTo(ServiceCharge sc, ServiceChargeDto dto);
    }

    public class ServiceChargeAssembler : IServiceChargeAssembler
    {
        public void copyFrom(ServiceChargeDto dto, ServiceCharge sc)
        {
            dto.Id = sc.Id;
            dto.CreatedBy = sc.CreatedBy;
            dto.CreatedDate = sc.CreatedDate;
            dto.Name = sc.Name;
            dto.ServicePercent = sc.ServicePercent;
            dto.Status = sc.Status;
        }

        public void copyTo(ServiceCharge sc, ServiceChargeDto dto)
        {
            sc.CreatedBy = dto.CreatedBy;
            sc.CreatedDate = DateTime.Now;
            sc.Name = dto.Name;
            sc.ServicePercent = dto.ServicePercent;
            sc.Activate();
        }

        public void modifyTo(ServiceCharge sc, ServiceChargeDto dto)
        {
            sc.Id = dto.Id;
            sc.CreatedBy = dto.CreatedBy;
            sc.CreatedDate = dto.CreatedDate;
            sc.ModifiedBy = dto.ModifiedBy;
            sc.ModifiedDate = DateTime.Now;
            sc.Name = dto.Name;
            sc.ServicePercent = dto.ServicePercent;
            sc.Status = dto.Status;
        }
    }
}
