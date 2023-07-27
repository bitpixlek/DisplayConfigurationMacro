using DisplayConfigurationMacro.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayConfigurationMacro.Business.Helper
{
    public class SytemProcessHelper
    {
        public static bool ProcessOnListIsRunning(ConfigurationParameterModel config)
        {
            List<Process> localProcess = Process.GetProcesses().ToList<Process>();
            List<Process> filteredProcess = localProcess.Select(x => x).Where(x => config.PIDProcess.Contains(x.ProcessName)).ToList();
            if (filteredProcess.Count > 1) return true;
            return false;
        }
    }
}
