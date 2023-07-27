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
        public DisplayHandle ContextDisplay { get; set; }
        public DVCInformation _digitalVibrance { get; set; }

        public DisplayConfigurationsModel(Display display)
        {
            this.ContextDisplay = display.Handle;
            this._digitalVibrance = new DVCInformation(this.ContextDisplay);
        }

        public int GetDigitalVibrance() =>
           _digitalVibrance.CurrentLevel;

        public void SetDigitalVibrance(int value) =>
            _digitalVibrance.CurrentLevel = value;
    }
}
