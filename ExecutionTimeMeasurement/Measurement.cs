using System;
using System.Diagnostics;
using System.Reflection;
using System.Threading;

namespace ExecutionTimeMeasurement
{
    public sealed class Measurement
    {

        private const string EXCEPTION_MESSAGE_ATTRIBUTE_IS_NULL = "Attribute is null";
        private const string EXCEPTION_MESSAGE_GENERAL_FAILURE_OCCURRED = "A general failure occurred";

        private const ThreadPriority THREAD_PRIORITY = ThreadPriority.Highest;

        private static Stopwatch _stopwatch = null;

        public Measurement()
        {
            _stopwatch = new Stopwatch();
        }

        /// <summary>
        /// Execution of the measurement process
        /// </summary>
        /// <param name="action">Method to be executed</param>
        /// <returns>Object <see cref="MeasureResult"/> with the results of the measurement</returns>
        public static MeasureResult Exec(Action action)
        {
            MeasureResult results = Initialize(action.Method);

            for (int i = 0; i < results.Iterations; i++)
            {
                _stopwatch.Reset();
                _stopwatch.Start();

                action();

                _stopwatch.Stop();
                GC.Collect();

                results.AddTime(i, _stopwatch.Elapsed);
            }

            return results;
        }

        /// <summary>
        /// Execution of the measurement process
        /// </summary>
        /// <typeparam name="T">Type of the parameter</typeparam>
        /// <param name="action">Method to be executed</param>
        /// <param name="parameter">Parameter value</param>
        /// <returns>Object <see cref="MeasureResult"/> with the results of the measurement</returns>
        public static MeasureResult Exec<T>(Action<T> action, T parameter)
        {
            MeasureResult results = Initialize(action.Method);

            for (int i = 0; i < results.Iterations; i++)
            {
                _stopwatch.Reset();
                _stopwatch.Start();

                action(parameter);

                _stopwatch.Stop();
                GC.Collect();

                results.AddTime(i, _stopwatch.Elapsed);
            }

            return results;
        }

        /// <summary>
        /// Execution of the measurement process
        /// </summary>
        /// <typeparam name="T1">Type of the parameter</typeparam>
        /// <typeparam name="T2">Type of the parameter</typeparam>
        /// <param name="action">Method to be executed</param>
        /// <param name="parameter1">Parameter value</param>
        /// <param name="parameter2">Parameter value</param>
        /// <returns>Object <see cref="MeasureResult"/> with the results of the measurement</returns>
        public static MeasureResult Exec<T1, T2>(Action<T1, T2> action, T1 parameter1, T2 parameter2)
        {
            MeasureResult results = Initialize(action.Method);

            for (int i = 0; i < results.Iterations; i++)
            {
                _stopwatch.Reset();
                _stopwatch.Start();

                action(parameter1, parameter2);

                _stopwatch.Stop();
                GC.Collect();

                results.AddTime(i, _stopwatch.Elapsed);
            }

            return results;
        }

        /// <summary>
        /// Execution of the measurement process
        /// </summary>
        /// <typeparam name="T1">Type of the parameter</typeparam>
        /// <typeparam name="T2">Type of the parameter</typeparam>
        /// <typeparam name="T3">Type of the parameter</typeparam>
        /// <param name="action">Method to be executed</param>
        /// <param name="parameter1">Parameter value</param>
        /// <param name="parameter2">Parameter value</param>
        /// <param name="parameter3">Parameter value</param>
        /// <returns>Object <see cref="MeasureResult"/> with the results of the measurement</returns>
        public static MeasureResult Exec<T1, T2, T3>(Action<T1, T2, T3> action, T1 parameter1, T2 parameter2, T3 parameter3)
        {
            MeasureResult results = Initialize(action.Method);

            for (int i = 0; i < results.Iterations; i++)
            {
                _stopwatch.Reset();
                _stopwatch.Start();

                action(parameter1, parameter2, parameter3);

                _stopwatch.Stop();
                GC.Collect();

                results.AddTime(i, _stopwatch.Elapsed);
            }

            return results;
        }

        /// <summary>
        /// Execution of the measurement process
        /// </summary>
        /// <typeparam name="T1">Type of the parameter</typeparam>
        /// <typeparam name="T2">Type of the parameter</typeparam>
        /// <typeparam name="T3">Type of the parameter</typeparam>
        /// <typeparam name="T4">Type of the parameter</typeparam>
        /// <param name="action">Method to be executed</param>
        /// <param name="parameter1">Parameter value</param>
        /// <param name="parameter2">Parameter value</param>
        /// <param name="parameter3">Parameter value</param>
        /// <param name="parameter4">Parameter value</param>
        /// <returns>Object <see cref="MeasureResult"/> with the results of the measurement</returns>
        public static MeasureResult Exec<T1, T2, T3, T4>(Action<T1, T2, T3, T4> action, T1 parameter1, T2 parameter2, T3 parameter3, T4 parameter4)
        {
            MeasureResult results = Initialize(action.Method);

            for (int i = 0; i < results.Iterations; i++)
            {
                _stopwatch.Reset();
                _stopwatch.Start();

                action(parameter1, parameter2, parameter3, parameter4);

                _stopwatch.Stop();
                GC.Collect();

                results.AddTime(i, _stopwatch.Elapsed);
            }

            return results;
        }

        /// <summary>
        /// Execution of the measurement process
        /// </summary>
        /// <typeparam name="T1">Type of the parameter</typeparam>
        /// <typeparam name="T2">Type of the parameter</typeparam>
        /// <typeparam name="T3">Type of the parameter</typeparam>
        /// <typeparam name="T4">Type of the parameter</typeparam>
        /// <typeparam name="T5">Type of the parameter</typeparam>
        /// <param name="action">Method to be executed</param>
        /// <param name="parameter1">Parameter value</param>
        /// <param name="parameter2">Parameter value</param>
        /// <param name="parameter3">Parameter value</param>
        /// <param name="parameter4">Parameter value</param>
        /// <param name="parameter5">Parameter value</param>
        /// <returns>Object <see cref="MeasureResult"/> with the results of the measurement</returns>
        public static MeasureResult Exec<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> action, T1 parameter1, T2 parameter2, T3 parameter3, T4 parameter4, T5 parameter5)
        {
            MeasureResult results = Initialize(action.Method);

            for (int i = 0; i < results.Iterations; i++)
            {
                _stopwatch.Reset();
                _stopwatch.Start();

                action(parameter1, parameter2, parameter3, parameter4, parameter5);

                _stopwatch.Stop();
                GC.Collect();

                results.AddTime(i, _stopwatch.Elapsed);
            }

            return results;
        }

        /// <summary>
        /// Initialization method to start a measurement
        /// </summary>
        /// <param name="methodInfo"></param>
        /// <returns>Object <see cref="MeasureResult"/> to keep the results of the measurement</returns>
        private static MeasureResult Initialize(MethodInfo methodInfo)
        {
            try
            {
                MeasureAttribute attribute = (MeasureAttribute)methodInfo.GetCustomAttributes(typeof(MeasureAttribute), true)[0];
                if (attribute == null) throw new MeasureException(EXCEPTION_MESSAGE_ATTRIBUTE_IS_NULL);

                MeasureResult results = new MeasureResult(attribute.Name, attribute.Description, attribute.Iterations);

                Thread.CurrentThread.Priority = THREAD_PRIORITY;

                _stopwatch = new Stopwatch();

                return results;
            }
            catch (Exception ex)
            {
                throw new MeasureException(EXCEPTION_MESSAGE_GENERAL_FAILURE_OCCURRED, ex);
            }
        }

    }

}