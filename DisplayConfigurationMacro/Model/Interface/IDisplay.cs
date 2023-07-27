using NvAPIWrapper.Display;
using NvAPIWrapper.Native.Display.Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayConfigurationMacro.Model.Interface
{
    interface IDisplay
    {
        DisplayHandle ContextDisplay { get; set; }
        DVCInformation _digitalVibrance { get; set; }

        void SetDigitalVibrance(int value);
        int GetDigitalVibrance();
    }
}
