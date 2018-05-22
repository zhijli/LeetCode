using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class P120
    {
        public int MinimumTotal(IList<IList<int>> triangle)
        {
            var count = triangle.Count;
            int[,] dp = new int[count, count];

            for (int j = 0; j < count; j++)
            {
                dp[count - 1, j] = triangle[count - 1][j];
            }

            for (int i = count - 2; i >= 0; i--)
            {
                for (int j = 0; j <= i; j++)
                {
                    dp[i, j] = Math.Min(dp[i + 1, j], dp[i + 1, j + 1]) + triangle[i][j];
                }
            }

            return dp[0, 0];
        }
    }
}
