using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FiboInfraStructure.Entity.FiboInventory
{
    public class Item: BaseCounterEntity
    {
        public string Name { get; set; }

        [ForeignKey("MeasuringUnitId")]
        public long? MeasuringUnitId { get; set; }
    }
}
