﻿using DisplayConfigurationMacro.Business.Helper;
using DisplayConfigurationMacro.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayConfigurationMacro.Business
{
    public class ProcessHandle
    {
        private List<Process> _processes { get; set; }
        private ConfigurationParameterModel _configParam { get; set; }

        public ProcessHandle()
        {
            this._configParam = ConfigurationParametersHelper.GetConfiguration();
            this._processes = SytemProcessHelper.ProcessOnListIsRunning(this._configParam);
        }

        public void SetProcessPriority()
        {
            foreach (Process process in _processes)
            {
                ProcessDetails details = _configParam.PIDProcess.Select(x => x).Where(x => x.ProcessName.Equals(process.ProcessName)).FirstOrDefault();
                if (details == null) continue;

                process.PriorityClass = (ProcessPriorityClass)(int)details.Priority;
            }
        }
    }
}