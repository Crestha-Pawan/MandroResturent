using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FiboInfraStructure.Entity
{
    public class BaseCounterEntity : BaseEntity
    {
        [ForeignKey("BranchId")]
        public long? BranchId { get; set; }
    }
}
