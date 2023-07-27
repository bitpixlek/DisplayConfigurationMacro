using DisplayConfigurationMacro.Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayConfigurationMacroTest.Business
{
    [TestClass]
    public class DeviceHandleTest
    {
        [TestMethod]
        public void DeviceValidationTest()
        {
            new DevideHandle().DeviceValidation();
        }

    }
}
