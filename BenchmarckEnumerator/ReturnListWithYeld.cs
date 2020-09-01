using System.Collections.Generic;

namespace BenchmarckEnumerator
{
    public class ReturnListWithYield
    {
        public IEnumerable<long> GetList(IEnumerable<long> listResult)
        {
            foreach (var item in listResult)
            {
                yield return item;
            }
        }
    }
}
