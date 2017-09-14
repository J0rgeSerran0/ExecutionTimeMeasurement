using ExecutionTimeMeasurement;
using System;
using System.Collections.Generic;

namespace NetCoreDemo
{

    public class Process
    {

        [Measure(nameof(ExecutionWithoutParams), "Sample test without params", 3)]
        public void ExecutionWithoutParams()
        {
            List<int> values = new List<int>();
            for (int i = 0; i < 1000; i++)
            {
                values.Add(i);
            }
        }

        [Measure(nameof(ExecutionWithOneParam), "Sample test with one param", 5)]
        public void ExecutionWithOneParam(int count)
        {
            List<int> values = new List<int>();
            for (int i = 0; i < count; i++)
            {
                values.Add(i);
            }
        }

        public void ExecutionWithoutAttribute()
        {
            List<int> values = new List<int>();
            for (int i = 0; i < 1000; i++)
            {
                values.Add(i);
            }
        }

        public void ShowDetails(MeasureResult measureResult)
        {
            int counter = 30;
            string separator = new String('=', counter);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("TEST DETAILS");
            Console.WriteLine($"\t{measureResult.Name}");
            Console.WriteLine($"\t{measureResult.Description}");
            Console.WriteLine($"\t{measureResult.Iterations} iteration(s)");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("RESULTS");

            for (int i = 0; i < measureResult.ResultTime.Length; i++)
            {
                Console.WriteLine($"\t ({i + 1})");
                Console.WriteLine($"\t{measureResult.ResultTime[i].Elapsed.TotalMilliseconds} miliseconds");
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("AVERAGE");
            Console.WriteLine($"\t{measureResult.CalculateAverage().TotalMilliseconds} miliseconds");
            Console.WriteLine(Environment.NewLine);
        }

    }

}