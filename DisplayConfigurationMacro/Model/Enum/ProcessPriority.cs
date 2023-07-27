using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DisplayConfigurationMacro.Model.Enum
{
    public enum ProcessPriority
    {
        [EnumMember(Value = "Normal")]
        Normal = 32,
        [EnumMember(Value = "Idle")]
        Idle = 64,
        [EnumMember(Value = "High")]
        High = 128,
        [EnumMember(Value = "RealTime")]
        RealTime = 256,
        [EnumMember(Value = "BelowNormal")]
        BelowNormal = 16384,
        [EnumMember(Value = "AboveNormal")]
        AboveNormal = 32768
    }
}
