using BenchmarkDotNet.Running;

namespace Benchmarker
{
    class Program { 
        static void Main(string[] args)
        {
            var results = BenchmarkRunner.Run<Demo>();
        }
    }
}