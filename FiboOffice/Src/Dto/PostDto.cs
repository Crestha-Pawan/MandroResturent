using FiboInfraStructure.Entity.FiboOffice;
using FiboInfraStructure.Src;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace FiboOffice.Src.Dto
{
     public class PostDto: BaseDto
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public IList<Post> Posts { get; set; } = new List<Post>();
        public SelectList PostList => new SelectList(Posts, nameof(Post.Id), nameof(Post.Name));
    }
}
