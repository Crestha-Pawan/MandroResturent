using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace FiboInfraStructure.Enums
{
    public enum Status
    {
        [Description("Vacant Clean")]
        VacantClean=1,
        [Description("Engaged")]
        Engaged = 2,
        [Description("Vacant Dirty")]
        VacantDirty=3,
        [Description("Reserved")]
        Reserved=4,
    }
}
