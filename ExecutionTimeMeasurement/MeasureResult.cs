using System;
using System.Linq;

namespace ExecutionTimeMeasurement
{
    public class MeasureResult
    {
        private readonly string _name;
        public string Name => _name;

        private readonly string _description;
        public string Description => _description;

        private readonly int _iterations;
        public int Iterations => _iterations;

        private readonly MeasureTime[] _resultTime;
        public MeasureTime[] ResultTime => _resultTime;

        public MeasureResult(string name, string description, int iterations)
        {
            _name = name;
            _description = description;
            _iterations = iterations;
            _resultTime = new MeasureTime[iterations];
        }

        public void AddTime(int position, TimeSpan elapsed)
        {
            ResultTime[position] = new MeasureTime(elapsed);
        }

        public TimeSpan CalculateAverage()
        {
            double doubleAverageTicks = ResultTime.Average(timeSpan => timeSpan.Elapsed.Ticks);
            long longAverageTicks = Convert.ToInt64(doubleAverageTicks);

            return new TimeSpan(longAverageTicks);
        }

    }

}