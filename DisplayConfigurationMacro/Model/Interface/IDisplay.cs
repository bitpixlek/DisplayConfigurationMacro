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
        int CurrentDigitalVibrance { get; set; }
        DisplayHandle ContextDisplay { get; set; }

        void SetDigitalVibrance(int value);
        int GetDigitalVibrance();
    }
}
