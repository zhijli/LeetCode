// -----------------------------------------------------------------------
//  <copyright company="Microsoft">
//      Copyright (c) Microsoft Corporation.  All rights reserved.
//  </copyright>
// -----------------------------------------------------------------------

namespace LeetCode
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class P10
    {
        static bool?[,] dp;
        public bool IsMatch(string s, string p)
        {
            dp = new bool?[s.Length + 1, p.Length + 1];
            return IsMatch(s, 0, p, 0);
        }

        private bool IsMatch(string s, int i, string p, int j)
        {        
            if (dp[i, j] != null)
            {
                return dp[i, j].Value;
            }

            if (i == s.Length && j == p.Length)
            {
                dp[i, j] = true;
                return true;
            }
            if(i != s.Length && j==p.Length)
            {
                dp[i, j] = false;
                return false;
            }

            if (j + 1 < p.Length && p[j + 1] == '*')
            {

                dp[i, j] = IsMatch(s, i, p, j + 2) || (i < s.Length && (s[i] == p[j] || p[j] == '.') && IsMatch(s, i + 1, p, j));
                return dp[i, j].Value;
            }
            else
            {
                dp[i, j] = (i < s.Length && (s[i] == p[j] || p[j] == '.') && IsMatch(s, i + 1, p, j + 1));
                return dp[i, j].Value;
            }
        }
    }
}

