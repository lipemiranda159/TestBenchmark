using BenchmarkDotNet.Running;
using System;
using System.Diagnostics;

namespace BenchmarckEnumerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<ListBenchmarks>();
            Console.WriteLine(summary.ToString());
            var returnListWithoutYield = new ReturnListWithoutYield();
            var returnListWithYield = new ReturnListWithYield();

            var stopWatch = new Stopwatch();
            stopWatch.Start();
            returnListWithoutYield.GetList(GitProvider.GetGitResults());
            stopWatch.Stop();
            Console.WriteLine($"Tempo: {stopWatch.ElapsedMilliseconds}");
            stopWatch.Reset();

            stopWatch.Start();
            returnListWithYield.GetList(GitProvider.GetGitResults());
            stopWatch.Stop();
            Console.WriteLine($"Tempo: {stopWatch.ElapsedMilliseconds}");
            Console.ReadLine();

        }
    }
}
