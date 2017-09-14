using System;
using System.Runtime.Serialization;

namespace ExecutionTimeMeasurement
{

    /// <summary>
    /// Exception used in the measure process
    /// </summary>
    public class MeasureException : Exception
    {
        public MeasureException()
        {
        }

        public MeasureException(string message)
        : base(message)
        {
        }

        public MeasureException(string message, Exception inner)
        : base(message, inner)
        {
        }

        public MeasureException(SerializationInfo serializationInfo, StreamingContext streamingContext)
        : base(serializationInfo, streamingContext)
        {
        }
    }

}