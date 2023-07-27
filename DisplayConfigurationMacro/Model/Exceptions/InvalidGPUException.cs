using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayConfigurationMacro.Model.Exceptions
{
    [Serializable]
    class InvalidGPUException : Exception
    {
        public InvalidGPUException() { }

        public InvalidGPUException(string name)
            : base(String.Format("Invalid GPU: {0}", name))
        {

        }
    }

}
