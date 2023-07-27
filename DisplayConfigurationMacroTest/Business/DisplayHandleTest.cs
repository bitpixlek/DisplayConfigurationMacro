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
    public class DisplayHandleTest
    {
        public DisplayHandle DisplayHandle { get; set; }

        [TestInitialize]
        public void TestInicializer()
        {
            this.DisplayHandle = new DisplayHandle();
        }

        [TestMethod]
        public void DisplaySelectorTest()
        {
            this.DisplayHandle.DisplaySelector();
        }
    }
}
