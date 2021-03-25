using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;
namespace Ampel.Data
{
    public class TimerService
    {

        public TimerService()
        {
            _timer = new Timer();
            _timer.Elapsed += NotifyTimerElapsed;
            _timer.Enabled = true;
            _timer.AutoReset = false;
        }
        private Timer _timer;

        public void SetTimer(double interval)
        {
            _timer.Interval = interval;
            _timer.Start();
        }

        public event Action OnElapsed;

        private void NotifyTimerElapsed(Object source, ElapsedEventArgs e)
        {
            OnElapsed?.Invoke();
        
        }
    }
}
