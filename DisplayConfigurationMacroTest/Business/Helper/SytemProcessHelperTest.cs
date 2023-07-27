using DisplayConfigurationMacro.Business.Helper;
using DisplayConfigurationMacro.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayConfigurationMacroTest.Business.Helper
{
    [TestClass]
    public class SytemProcessHelperTest
    {
        [TestMethod]
        public void ProcessOnListIsRunning()
        {
            ConfigurationParameterModel jsonConfiguration = ConfigurationParametersHelper.GetConfiguration();
            SytemProcessHelper.ProcessOnListIsRunning(jsonConfiguration);
        }
    }
}
