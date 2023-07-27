using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DisplayConfigurationMacro.Model.Exceptions;
using NvAPIWrapper;
using NvAPIWrapper.GPU;

namespace DisplayConfigurationMacro.Business
{
    public class DeviceHandle
    {
        public static void DeviceValidation()
        {
            string fullname = GetDeviceName();

            if (string.IsNullOrEmpty(fullname))
                throw new InvalidGPUException("No Nvidias GPU's on current Machine");
        }

        public static string GetDeviceName()
        {
            List<PhysicalGPU> gpus = PhysicalGPU.GetPhysicalGPUs().ToList();
            List<PhysicalGPU> nvidiaGpus = gpus.Where(x => x.FullName.Contains("NVIDIA")).Select(x => x).ToList();

            return nvidiaGpus?.FirstOrDefault()?.FullName;
        }
    }
}
