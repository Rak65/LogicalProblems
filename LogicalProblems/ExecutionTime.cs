using System;
using System.Diagnostics;

namespace LogicalProblems
{
    public class ExecutionTime
    {
        public void ExecuTime()
        {
            Console.WriteLine("Enter any key to start the execution time.");
            Console.ReadKey();
            Stopwatch sw = new Stopwatch();
            sw.Start();

            Console.WriteLine("Enter any key to stop the stopwatch.");
            Console.ReadKey();
            sw.Stop();
            Console.WriteLine("Total execution time : "+sw.ElapsedMilliseconds+" milliseconds");
        }
    }
}
