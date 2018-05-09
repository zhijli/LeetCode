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

    public class P87
    {
        private bool?[,,] dp;
        public bool IsScramble(string s1, string s2)
        {
            if (s1.Length != s2.Length) return false;
            dp = new bool?[s1.Length, s1.Length, s1.Length + 1];
            return IsScramble(s1, 0, s2, 0, s1.Length);
        }

        public bool IsScramble(string s1, int v1, string s2, int v2, int length)
        {
            if (length == 0) return true;
            if (length == 1 && s1[v1] == s2[v2])
            {
                dp[v1, v2, length] = true;
                return true;
            }
            if (dp[v1, v2, length] != null) return dp[v1, v2, length].Value;

            for (int i = 1; i < length; i++)
            {
                var t1 = IsScramble(s1, v1, s2, v2, i);
                var t2 = IsScramble(s1, v1 + i, s2, v2 + i, length - i);
                if (t1 && t2)
                {
                    dp[v1, v2, length] = true;
                    return true;
                }

                var t3 = IsScramble(s1, v1 + i, s2, v2, length - i);
                var t4 = IsScramble(s1, v1, s2, v2 + length - i, i);

                if (t3 && t4)
                {
                    dp[v1, v2, length] = true;
                    return true;
                }
            }
            dp[v1, v2, length] = false;
            return false;
        }
    }
}
