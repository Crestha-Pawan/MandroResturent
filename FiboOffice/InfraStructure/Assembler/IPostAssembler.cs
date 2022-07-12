using FiboInfraStructure.Entity.FiboOffice;
using FiboOffice.Src.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace FiboOffice.InfraStructure.Assembler
{

    public interface IPostAssembler
    {
        void copyTo(Post post, PostDto dto);
        void copyFrom(PostDto dto, Post post);
        void modifyTo(Post post, PostDto dto);
    }
    public class PostAssembler : IPostAssembler
    {


        public void copyFrom(PostDto dto, Post post)
        {
            dto.BranchId = post.BranchId;
            dto.Id = post.Id;
            dto.CreatedBy = post.CreatedBy;
            dto.CreatedDate = post.CreatedDate;
            dto.Name = post.Name;
            dto.Salary = post.Salary;
        }
        public void modifyTo(Post post, PostDto dto)
        {
            post.BranchId = dto.BranchId;
            post.Id = dto.Id;
            post.CreatedBy = dto.CreatedBy;
            post.CreatedDate = DateTime.Now;
            post.Name = dto.Name;
            post.Salary = dto.Salary;
            post.ModifiedBy = dto.ModifiedBy;
            post.ModifiedDate = DateTime.Now;
        }

        public void copyTo(Post post, PostDto dto)
        {
            post.CreatedBy = dto.CreatedBy;
            post.CreatedDate = DateTime.Now;
            post.Name = dto.Name;
            post.Salary = dto.Salary;
            post.BranchId = dto.BranchId;
        }

    }
}

