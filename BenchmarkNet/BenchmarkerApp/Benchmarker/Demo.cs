using System.Text;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace Benchmarker
{
    [SimpleJob(RuntimeMoniker.Net50, baseline: true)]
    [SimpleJob(RuntimeMoniker.Net60)]
    [MemoryDiagnoser]
    public class Demo
    {
        [Benchmark] // (Baseline = true)
        public string GetFullStringNormally()
        {
            string output = "";

            for (int i = 0; i < 100; i++)
            {
                output += i;
            }

            return output;
        }

        [Benchmark]
        public string GetFullStringWithStringBuilder()
        {
            StringBuilder output = new StringBuilder();

            for (int i = 0; i < 100; i++)
            {
                output.Append(i);
            }

            return output.ToString();
        }
    }
}