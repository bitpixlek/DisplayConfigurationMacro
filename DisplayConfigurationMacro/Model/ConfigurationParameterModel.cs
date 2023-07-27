using DisplayConfigurationMacro.Model.Enum;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayConfigurationMacro.Model
{
    public class ConfigurationParameterModel
    {
        [JsonProperty(PropertyName = "DefaultValue")]
        public int DefaultValue { get; set; }

        [JsonProperty(PropertyName = "CustomValue")]
        public int CustomValue { get; set; }

        [JsonProperty(PropertyName = "PIDProcess")]
        public List<ProcessDetails> PIDProcess { get; set; }
    }

    public class ProcessDetails
    {
        [JsonProperty(PropertyName = "ProcessName")]
        public string ProcessName { get; set; }
        [JsonProperty(PropertyName = "Priority")]
        public ProcessPriority Priority { get; set; }
    }
}
