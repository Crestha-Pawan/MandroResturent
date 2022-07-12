using System;
using System.Collections.Generic;
using System.Text;
using FiboInfraStructure.Entity.FiboInventory;
using FiboInfraStructure.Src;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FiboInventory.Src.Dto
{
    public class ProductCategoryDto : BaseDto
    {
        public string Name { get; set; }

        public List<ProductSubCategoryDto> SubCategoryDtos { get; set; }
        public bool hassubcategory()
        {
            return SubCategoryDtos.Count > 0;
        }
    }
}