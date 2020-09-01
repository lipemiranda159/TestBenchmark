using System.Collections.Generic;
using System.Linq;

namespace BenchmarckEnumerator
{
    public class ReturnListWithoutYield
    {
        public List<long> GetList(IEnumerable<long> listResult)
        {
            var list = new List<long>(listResult.Count());
            foreach (var item in listResult)
            {
                list.Add(item);
            }

            return list;
        }
    }
}
