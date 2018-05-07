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

    public class P93
    {
        public IList<string> RestoreIpAddresses(string s)
        {
            if (s == null || s.Length < 4) return new List<string>();

            var dp = new List<List<string>>[s.Length, 5];
            for (int i = s.Length - 1; i >= 0; i--)
            {
                for (int j = 4; j >= 0; j--)
                {
                    if (s.Length - i < j || j == 0)
                    {
                        dp[i, j] = new List<List<string>>();
                    }
                }
            }

            for (int i = s.Length - 1; i >= 0; i--)
            {
                for (int j = 4; j >= 0; j--)
                {
                    if (s[i] == '0')
                    {
                        var l = new List<List<string>>(dp[i + 1, j - 1]);
                        l.ForEach(str => str.Add("0"));
                        dp[i, j] = l;
                    }

                    if (s[i] == '1')
                    {
                        var l = new List<List<string>>(dp[i + 1, j - 1]);
                        l.ForEach(str => str.Add("1"));
                        dp[i, j] = l;

                        l = new List<List<string>>(dp[i + 2, j - 1]);
                        l.ForEach(str => str.Add(s.Substring(i,2)));
                        dp[i, j].AddRange(l);

                        l = new List<List<string>>(dp[i + 3, j - 1]);
                        l.ForEach(str => str.Add(s.Substring(i, 3)));
                        dp[i, j].AddRange(l);
                    }

                    if (s[i] == '2')
                    {
                        var l = new List<List<string>>(dp[i + 1, j - 1]);
                        l.ForEach(str => str.Add("1"));
                        dp[i, j] = l;

                        l = new List<List<string>>(dp[i + 2, j - 1]);
                        l.ForEach(str => str.Add(s.Substring(i, 2)));
                        dp[i, j].AddRange(l);

                        l = new List<List<string>>(dp[i + 3, j - 1]);
                        l.ForEach(str => str.Add(s.Substring(i, 3)));
                        dp[i, j].AddRange(l);
                    }

                    dp[i, j] = dp[i + 1, j - 1] + dp[i + 2, j - 1] + dp[i + 3, j - 1];
                }
            }

            var result = new List<string>();
            var current = new List<string>();



            return result;
        }
    }
}
