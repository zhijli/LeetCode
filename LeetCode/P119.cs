using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class P119
    {
        public IList<int> GetRow(int rowIndex)
        {
            var result = new List<int> { 1 };
            if (rowIndex == 0) return result;
            var i = rowIndex;
            var j = 1;
            long temp = 1;

            while (j < i)
            {
                temp = temp * i / j;
                result.Add((int)temp);
                i--;
                j++;
            }

            for (int k = result.Count - 1; k >= 0; k--)
            {
                if (rowIndex % 2 != 0 || k != result.Count - 1) result.Add(result[k]);
            }

            return result;
        }
    }
}
