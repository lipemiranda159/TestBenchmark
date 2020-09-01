using System.Collections.Generic;

namespace BenchmarckEnumerator
{
    public static class GitProvider
    {

        public static IEnumerable<long> GetGitResults()
        {
            for (int i = 0; i < 1000000000; i++)
            {
                yield return i;
            }
        }
    }
}
