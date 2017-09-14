using System;

namespace ExecutionTimeMeasurement
{

    /// <summary>
    /// Attribute to be used by the measurement process
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    public class MeasureAttribute : Attribute
    {
        private readonly string _name;
        public string Name => _name;

        private readonly string _description;
        public string Description => _description;

        private readonly int _iterations;
        public int Iterations => _iterations;

        /// <summary>
        /// Constructor of the attribute.
        /// </summary>
        /// <param name="name">Name of the method to measure</param>
        /// <param name="description">Description of the method to measure</param>
        /// <param name="iterations">Number of iterations of the method execution. The number of iterations will be 1 if the iterations value is less than 1</param>
        public MeasureAttribute(string name, string description, int iterations)
        {
            if (iterations < 1) iterations = 1;

            _name = name;
            _description = description;
            _iterations = iterations;
        }

    }

}