using FiboInfraStructure.Entity.FiboOffice;
using FiboInfraStructure.Src;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace FiboInventory.Src.Dto
{
    public class ItemDto : BaseDto
    {
        public string Name { get; set; }
        public long? MeasuringUnitId { get; set; }

        public IList<MeasuringUnit> MeasuringUnits { get; set; } = new List<MeasuringUnit>();
        public SelectList MeasuringUnitList => new SelectList(MeasuringUnits, nameof(MeasuringUnit.Id), nameof(MeasuringUnit.Name));

    }
}
