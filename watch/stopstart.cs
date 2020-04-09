using System;

namespace watch
{
    class Stopstart
    {
        private DateTime _start;
        private DateTime _stop;
        private bool _isrunning;


        public void Start()
        {
            if (_isrunning)
                throw new InvalidOperationException("stopwatch is already running");

            _start = DateTime.Now;
            _isrunning = true;
        }

        public void Stop()
        {
            if (!_isrunning)
                throw new InvalidOperationException("stopwatch has stopped already");

            _stop = DateTime.Now;
            _isrunning = false;
        }

        public TimeSpan Getduration()
        {
            return _stop.Subtract(_start);
            //return _start - _stop;
        }
    }
}
