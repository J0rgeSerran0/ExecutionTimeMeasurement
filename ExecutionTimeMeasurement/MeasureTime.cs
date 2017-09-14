using System;

namespace ExecutionTimeMeasurement
{

    /// <summary>
    /// Object to assign the time consumed in the measurement process
    /// </summary>
    public sealed class MeasureTime
    {
        private readonly TimeSpan _elapsed;
        public TimeSpan Elapsed => _elapsed;

        public MeasureTime(TimeSpan elapsed)
        {
            _elapsed = elapsed;
        }

    }

}