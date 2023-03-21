using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    internal class StopWatch
    {
        private bool _isStopWatchOn = false;
        private DateTime _start;

        public void StartTimer()
        {
            if(_isStopWatchOn == true)
                throw new InvalidOperationException("Timer was already turned on");

            _isStopWatchOn = true;
            _start = DateTime.Now;

        }

        public TimeSpan StopTimer()
        {
            if (!_isStopWatchOn)
                throw new InvalidOperationException("Timer has not started");

            _isStopWatchOn= false;
            return DateTime.Now - _start;

        }


    }
}
