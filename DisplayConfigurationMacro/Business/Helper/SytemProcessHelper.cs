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
        public static List<Process> ProcessOnListIsRunning(ConfigurationParameterModel config)
        {
            List<Process> localProcess = Process.GetProcesses().ToList<Process>();
            List<Process> filteredProcess = new List<Process>();
            foreach (var targetProcess in config.PIDProcess)
            {
                filteredProcess.AddRange(localProcess.Select(x => x).Where(x => x.ProcessName == targetProcess.ProcessName).ToList());
            }
            return filteredProcess;
        }
    }
}
