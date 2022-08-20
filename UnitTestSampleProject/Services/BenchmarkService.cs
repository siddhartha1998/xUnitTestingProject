using BenchmarkDotNet.Attributes;
using System.Text;

namespace UnitTestSampleProject.Services
{
    [MemoryDiagnoser]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class BenchmarkService
    {
        readonly int NumberOfItems = 100000;
        [Benchmark]
        public string ConcatStringsUsingStringBuilder()
        {
            var sb = new StringBuilder();
            for (int i = 0; i < NumberOfItems; i++)
            {
                sb.Append("Hello World!" + i);
            }
            return sb.ToString();
        }
        [Benchmark]
        public string ConcatStringsUsingGenericList()
        {
            var list = new List<string>(NumberOfItems);
            for (int i = 0; i < NumberOfItems; i++)
            {
                list.Add("Hello World!" + i);
            }
            return list.ToString();
        }
    }
}
