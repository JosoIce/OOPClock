using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace OOPClock
{
    public class Clock
    {
        private Counter _hour;
        private Counter _min;
        private Counter _sec;

        public Clock()
        {
            _hour = new Counter("hour");
            _min = new Counter("min");
            _sec = new Counter("sec");
        }
        
        public void Tick()
        {
            _sec.Increment();
            if (_sec.Value == "60")
            {
                _min.Increment();
                _sec.Reset();

                if (_min.Value == "60")
                {
                    _hour.Increment();
                    _min.Reset();

                    if (_hour.Value == "24")
                    {
                        _hour.Reset();
                    }
                }
            }
        }

        public string OutputTime
        {
            get
            {
                string time = String.Concat(_hour.Value + ":" + _min.Value + ":" + _sec.Value);
                return time;
            }
        }

        public void ResetClock()
        {
            _hour.Reset();
            _min.Reset();
            _sec.Reset();
        }
    }
}
