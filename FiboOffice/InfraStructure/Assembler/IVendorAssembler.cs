using FiboInfraStructure.Entity.FiboOffice;
using FiboOffice.Src.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace FiboOffice.InfraStructure.Assembler
{
    
    public interface IVendorAssembler
    {
        void copyTo(Vendor vendor, VendorDto dto);
        void copyFrom(VendorDto dto, Vendor vendor);
        void modifyTo(Vendor vendor, VendorDto dto);
    }

    public class VendorAssembler : IVendorAssembler
    {
        public void copyFrom(VendorDto dto, Vendor vendor)
        {
            dto.Id = vendor.Id;
            dto.CreatedBy = vendor.CreatedBy;
            dto.CreatedDate = vendor.CreatedDate;
            dto.VendorName = vendor.VendorName;
            dto.PhoneNumber = vendor.PhoneNumber;
            dto.Address = vendor.Address;
        }

        public void copyTo(Vendor vendor, VendorDto dto)
        {
            vendor.CreatedBy = dto.CreatedBy;
            vendor.CreatedDate = DateTime.Now;
            vendor.VendorName = dto.VendorName;
            vendor.PhoneNumber = dto.PhoneNumber;
            vendor.Address = dto.Address;
        }

        public void modifyTo(Vendor vendor, VendorDto dto)
        {
            vendor.Id = dto.Id;
            vendor.CreatedBy = dto.CreatedBy;
            vendor.CreatedDate = dto.CreatedDate;
            vendor.ModifiedBy = dto.ModifiedBy;
            vendor.ModifiedDate = DateTime.Now;
            vendor.VendorName = dto.VendorName;
            vendor.PhoneNumber = dto.PhoneNumber;
            vendor.Address = dto.Address;
        }
    }
}
