using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section02Namespace
{
    internal class StopWatch
    {
        private bool isStarted = false;
        private DateTime _startTime;

        public void Start() 
        {
            if (isStarted) throw (new InvalidOperationException("The stopwatch has already started."));

            _startTime = DateTime.Now;
            isStarted = true;
        }

        public TimeSpan Stop() 
        {
            if (!isStarted) throw (new InvalidOperationException("The stopwatch has not started yet."));

            DateTime currentTime = DateTime.Now;

            TimeSpan duration = currentTime - _startTime;
            isStarted = false;

            return duration;
        }
    }
}
