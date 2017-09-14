using ExecutionTimeMeasurement;
using System;
using System.Text;

namespace NetCoreDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Started");
            Console.WriteLine();

            try
            {
                Process process = new Process();

                MeasureResult measureResult = Measurement.Exec(process.ExecutionWithoutParams);
                process.ShowDetails(measureResult);

                measureResult = Measurement.Exec(process.ExecutionWithOneParam, 3);
                process.ShowDetails(measureResult);

                measureResult = Measurement.Exec(process.ExecutionWithoutAttribute);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                StringBuilder stringBuilder = GetMessagesFromInnerExceptions(ex);
                Console.WriteLine(stringBuilder.ToString());
            }
            finally
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Press any key to close it");
                Console.ReadKey();
            }
        }

        public static StringBuilder GetMessagesFromInnerExceptions(Exception ex)
        {
            StringBuilder message = new StringBuilder();
            Exception innerException = ex;

            do
            {
                message.Append((String.IsNullOrEmpty(innerException.Message) ? String.Empty : innerException.Message + Environment.NewLine));
                innerException = innerException.InnerException;
            }
            while (innerException != null);

            return message;
        }

    }

}