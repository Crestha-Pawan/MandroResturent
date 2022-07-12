using FiboBilling.Src.Dto;
using FiboInfraStructure.Entity.FiboBilling;
using System;
using System.Collections.Generic;
using System.Text;

namespace FiboBilling.InfraStructure.Assembler
{
    
    public interface ITableAssembler
    {
        void copyTo(Table table, TableDto dto);
        void copyFrom(TableDto dto, Table table);
        void modifyTo(Table table, TableDto dto);
    }

    public class TableAssembler : ITableAssembler
    {
        public void copyFrom(TableDto dto, Table table)
        {
            dto.Id = table.Id;
            dto.CreatedBy = table.CreatedBy;
            dto.CreatedDate = table.CreatedDate;
            dto.Name = table.Name;
            dto.ReferenceType = table.ReferenceType;
        }

        public void copyTo(Table table, TableDto dto)
        {
            table.CreatedBy = dto.CreatedBy;
            table.CreatedDate = DateTime.Now;
            table.Name = dto.Name;
            table.ReferenceType = dto.ReferenceType;
            
        }

        public void modifyTo(Table table, TableDto dto)
        {
            table.Id = dto.Id;
            table.CreatedBy = dto.CreatedBy;
            table.CreatedDate = dto.CreatedDate;
            table.ModifiedBy = dto.ModifiedBy;
            table.ModifiedDate = DateTime.Now;
            table.Name = dto.Name;
            table.ReferenceType = dto.ReferenceType;
        }
    }
}
