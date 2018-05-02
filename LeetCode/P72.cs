// -----------------------------------------------------------------------
//  <copyright company="Microsoft">
//      Copyright (c) Microsoft Corporation.  All rights reserved.
//  </copyright>
// -----------------------------------------------------------------------

namespace LeetCode
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class P72
    {
        public int MinDistance(string word1, string word2)
        {
            var n1 = word1.Length;
            var n2 = word2.Length;

            int[,] dp = new int[n1 + 1, n2 + 1];

            for (int i = 0; i <= n1; i++) dp[i, 0] = i;
            for (int i = 0; i <= n2; i++) dp[0, i] = i;

            for (int i = 1; i <= n1; i++)
            {
                for (int j = 1; j <= n2; j++)
                {
                    if (word1[i - 1] == word2[j - 1])
                    {
                        dp[i, j] = dp[i - 1, j - 1];
                    }
                    else
                    {
                        dp[i, j] = Math.Min(Math.Min(dp[i, j - 1], dp[i - 1, j]), dp[i - 1, j - 1]) + 1;
                    }
                }
            }
            return dp[n1, n2];
        }
    }
}
