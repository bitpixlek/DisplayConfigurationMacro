using DisplayConfigurationMacro.Business.Helper;
using DisplayConfigurationMacro.Model;
using NvAPIWrapper.Display;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayConfigurationMacro.Business
{
    public class ServiceMain
    {
        public void MainExecution()
        {
            ConfigurationParameterModel config = ConfigurationParametersHelper.GetConfiguration();
            DeviceHandle.DeviceValidation();

            ProcessHandle process = new ProcessHandle(config);
            DisplayHandle display = new DisplayHandle();
            Display selectedDisplay = display.DisplaySelector();
            DisplayConfigurationsModel displayConfig = new DisplayConfigurationsModel(selectedDisplay);

            if (process.ProcessIsOpen())
            {
                process.SetProcessPriority();

                if (displayConfig.GetDigitalVibrance() == config.CustomValue) return; 
                display.DisplayDigitalVibranceUpdate(display.DisplaySelector(), config.CustomValue);
            }
            else
            {
                if (displayConfig.GetDigitalVibrance() == config.CustomValue) return;
                display.DisplayDigitalVibranceUpdate(display.DisplaySelector(), config.DefaultValue);
            }
        }
    }
}
