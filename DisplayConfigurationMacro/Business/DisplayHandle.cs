using DisplayConfigurationMacro.Model;
using NvAPIWrapper.Display;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayConfigurationMacro.Business
{
    public class DisplayHandle
    {
        private List<Display> _availableDisplays { get; set; }

        public DisplayHandle()
        {
            this._availableDisplays = Display.GetDisplays().ToList();
        }

        public Display DisplaySelector()
        {
            Display higherRefreshRateDisplay = _availableDisplays.Where(x => x.DisplayDevice.CurrentTiming.Extra.RefreshRate == 240).Select(x => x).FirstOrDefault();
            return higherRefreshRateDisplay;
        }

        public void DisplayDigitalVibranceUpdate(DisplayConfigurationsModel display, int DigitalVibranceValue) =>
            display.SetDigitalVibrance(DigitalVibranceValue);

        public void DisplayDigitalVibranceUpdate(Display display, int DigitalVibranceValue) =>
            new DisplayConfigurationsModel(display).SetDigitalVibrance(DigitalVibranceValue);
    }
}
