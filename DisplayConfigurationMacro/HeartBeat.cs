using DisplayConfigurationMacro.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace DisplayConfigurationMacro
{
    public class HeartBeat
    {
        private readonly Timer _timer;

        public HeartBeat()
        {
            _timer = new Timer(6000) { AutoReset = true };
            _timer.Elapsed += TimerEvent;
        }

        private void TimerEvent(object sender, ElapsedEventArgs e)
        {
            ServiceMain service = new ServiceMain();
            service.MainExecution();
        }

        public void Start()
        {
            this._timer.Start();
        }

        public void Stop()
        {
            this._timer.Stop();
        }
    }
}
