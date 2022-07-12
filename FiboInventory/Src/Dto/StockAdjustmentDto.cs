using FiboInfraStructure.Entity.FiboInventory;
using FiboInfraStructure.Entity.FiboOffice;
using FiboInfraStructure.Src;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace FiboInventory.Src.Dto
{
    public class StockAdjustmentDto: BaseDto
    {
        public string AdjustmentDate { get; set; }
        public long? AdjustedBy { get; set; }

        public List<StockAdjustmentDetailDto> StockAdjustmentDetailDtos { get; set; }
        public IList<Item> Items { get; set; } = new List<Item>();
        public SelectList ItemList => new SelectList(Items, nameof(Item.Id), nameof(Item.Name));
        public IList<MeasuringUnit> MeasuringUnits { get; set; } = new List<MeasuringUnit>();
        public SelectList MeasuringUnitList => new SelectList(MeasuringUnits, nameof(MeasuringUnit.Id), nameof(MeasuringUnit.Name));

    }
}
