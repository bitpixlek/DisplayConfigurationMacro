using DisplayConfigurationMacro.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

namespace DisplayConfigurationMacro
{
    class Program
    {
        static void Main(string[] args)
        {
            //new ServiceMain().MainExecution();
            var exitCode = HostFactory.Run(x =>
            {
                x.Service<HeartBeat>(s =>
                {
                    s.ConstructUsing(heartBeat => new HeartBeat());
                    s.WhenStarted(heartBeat => heartBeat.Start());
                    s.WhenStopped(heartBeat => heartBeat.Stop());
                });

                x.RunAsLocalSystem();
                x.SetServiceName("DigitalVibranceWatcher");
                x.SetDisplayName("*Digital Vibrance Watcher*");
            });

            int exitCodeValue = (int)Convert.ChangeType(exitCode, exitCode.GetType());
            Environment.ExitCode = exitCodeValue;
        }
    }
}
