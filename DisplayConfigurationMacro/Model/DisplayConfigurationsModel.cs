using DisplayConfigurationMacro.Model.Interface;
using NvAPIWrapper.Display;
using NvAPIWrapper.Native.Display.Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayConfigurationMacro.Model
{
    public class DisplayConfigurationsModel : IDisplay
    {
        public int CurrentDigitalVibrance { get; set; }
        public DisplayHandle ContextDisplay { get; set; }

        public int GetDigitalVibrance() =>
           new DVCInformation(this.ContextDisplay).CurrentLevel;

        public void SetDigitalVibrance(int value) =>
            new DVCInformation(this.ContextDisplay).CurrentLevel = value;
    }
}
