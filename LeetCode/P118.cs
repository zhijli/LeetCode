using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class P118
    {
        public IList<IList<int>> Generate(int numRows)
        {

            var result = new List<IList<int>>();
            if (numRows == 0) return result;

            result.Add(new List<int> { 1 });
            for (int i = 1; i < numRows; i++)
            {
                result.Add(new List<int> { 1 });
                for (int j = 0; j < result[i - 1].Count - 1; j++)
                {

                    result[i].Add(result[i - 1][j] + result[i - 1][j + 1]);

                }
                result[i].Add(1);
            }

            return result;
        }
    }
}
