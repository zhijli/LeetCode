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

    public class P115
    {
        public int NumDistinct(string s, string t)
        {
            if (string.IsNullOrEmpty(t)) return 1;
            if (string.IsNullOrEmpty(s)) return 0;

            int[,] dp = new int[s.Length, t.Length];

            if (s[0] == t[0])
            {
                dp[0, 0] = 1;
            }

            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == t[0])
                {
                    dp[i, 0] = dp[i - 1, 0] + 1;
                }
                else
                {
                    dp[i, 0] = dp[i - 1, 0];
                }
            }


            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 1; j < t.Length; j++)
                {
                    if (j > i)
                    {
                        dp[i, j] = 0;

                    }
                    else
                    {
                        if (s[i] == t[j])
                        {
                            dp[i, j] = dp[i - 1, j - 1] + dp[i - 1, j];
                        }
                        else
                        {
                            dp[i, j] = dp[i - 1, j];
                        }
                    }
                }
            }
            return dp[s.Length - 1, t.Length - 1];
        }
    }
}
