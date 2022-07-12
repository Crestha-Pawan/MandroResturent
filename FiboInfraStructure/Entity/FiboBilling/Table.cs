using System;
using System.Collections.Generic;
using System.Text;

namespace FiboInfraStructure.Entity.FiboBilling
{
    public class Table : BaseCounterEntity
    {
        public string Name { get; set; }
        public int ReferenceType { get; set; }
    }

    public enum TableType
    {
        TypeBilling = 1,
        TypeTable = 2
    }
}
