using System;
using System.Diagnostics;

namespace Multiplik
{
    class Program
    {
        const int RunNum = 10_000;
        static void Main(string[] args)
        {
            Benchmark(new MultiplyFirstSolution());
            Benchmark(new MultiplySecondSolution());
            Benchmark(new MultiplyThirdSolution());
        }

        static void Benchmark(IMultiply multiply)
        {
            var testFramework = new TestMultiply();

            var watch = new Stopwatch();
            watch.Start();

            var testNo = 0;

            for (var i = 0; i < RunNum; i++)
                testNo = testFramework.CheckSolution(multiply);

            watch.Stop();

            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Checked {multiply.GetType().FullName}");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine(
                $"Did {testNo} checks times {RunNum} in" +
                $" {watch.ElapsedTicks} ticks or {watch.ElapsedMilliseconds} ms.");

            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.White;
        }
    }
}
