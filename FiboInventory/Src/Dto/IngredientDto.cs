using System;
using System.Collections.Generic;
using System.Text;
using FiboInfraStructure.Entity.FiboInventory;
using FiboInfraStructure.Entity.FiboOffice;
using FiboInfraStructure.Src;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FiboInventory.Src.Dto
{
   public class IngredientDto : BaseDto
    {
        public Decimal Quantity { get; set; }
        public long? MeasuringUnitId { get; set; }
        public long? ItemId { get; set; }
        public virtual MeasuringUnit MeasuringUnit { get; set; }
        public long? ProductId { get; set; }
        public virtual Product Product { get; set; }
        public IList<MeasuringUnit> MeasuringUnits { get; set; } = new List<MeasuringUnit>();
        public SelectList MeasuringUnitList => new SelectList(MeasuringUnits, nameof(MeasuringUnit.Id), nameof(MeasuringUnit.Name));
    }
}
