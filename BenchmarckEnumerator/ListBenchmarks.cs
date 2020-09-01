using BenchmarkDotNet.Attributes;

namespace BenchmarckEnumerator
{
    [MemoryDiagnoser]
    public class ListBenchmarks
    {
        private readonly ReturnListWithoutYield _returnListWithoutYeld;
        private readonly ReturnListWithYield _returnListWithYield;
        public ListBenchmarks()
        {
            _returnListWithoutYeld = new ReturnListWithoutYield();
            _returnListWithYield = new ReturnListWithYield();
        }

        [Benchmark]
        public void UseList()
        {
            _returnListWithoutYeld.GetList(GitProvider.GetGitResults());
        }

        [Benchmark]
        public void UseYield()
        {
            _returnListWithYield.GetList(GitProvider.GetGitResults());
        }
    }
}
