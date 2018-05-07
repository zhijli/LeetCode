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

            var dp = new List<List<string>>[s.Length + 1, 5];
            for (int i = s.Length; i >= 0; i--)
            {
                for (int j = 4; j >= 0; j--)
                {
                    if (s.Length == i)
                    {
                        if (j == 0)
                        {
                            dp[i, j] = new List<List<string>> { new List<string>() };
                        }
                        else
                        {
                            dp[i, j] = new List<List<string>>();
                        }
                    }
                    else if (s.Length - i < j || j == 0)
                    {
                        dp[i, j] = new List<List<string>>();
                    }

                }
            }
            dp[s.Length - 1, 1] = new List<List<string>> { new List<string> { s.Substring(s.Length - 1, 1) } };

            for (int i = s.Length - 2; i >= 0; i--)
            {
                for (int j = 4; j >= 1; j--)
                {
                    if (s[i] == '0')
                    {
                        var l = new List<List<string>>();
                        dp[i + 1, j - 1].ForEach(item => l.Add(new List<string>(item)));
                        l.ForEach(str => str.Add(s.Substring(i, 1)));
                        dp[i, j] = l;
                    }
                    else if (s[i] == '1')
                    {
                        var l = new List<List<string>>();
                        dp[i + 1, j - 1].ForEach(item => l.Add(new List<string>(item)));
                        l.ForEach(str => str.Add(s.Substring(i, 1)));
                        dp[i, j] = l;

                        if (i <= s.Length - 2)
                        {
                            var temp = new List<List<string>>();
                            dp[i + 2, j - 1].ForEach(item => temp.Add(new List<string>(item)));
                            temp.ForEach(str => str.Add(s.Substring(i, 2)));
                            dp[i, j].AddRange(temp);
                        }

                        if (i <= s.Length - 3)
                        {
                            var temp = new List<List<string>>();
                            dp[i + 3, j - 1].ForEach(item => temp.Add(new List<string>(item)));
                            temp.ForEach(str => str.Add(s.Substring(i, 3)));
                            dp[i, j].AddRange(temp);
                        }
                    }
                    else if (s[i] == '2')
                    {
                        var l = new List<List<string>>();
                        dp[i + 1, j - 1].ForEach(item => l.Add(new List<string>(item)));
                        l.ForEach(str => str.Add(s.Substring(i, 1)));
                        dp[i, j] = l;

                        if (i <= s.Length - 2 )
                        {
                            var temp = new List<List<string>>();
                            dp[i + 2, j - 1].ForEach(item => temp.Add(new List<string>(item)));
                            temp.ForEach(str => str.Add(s.Substring(i, 2)));
                            dp[i, j].AddRange(temp);
                        }

                        if (i <= s.Length - 3 && (s[i + 1] <= '4' ||  s[i + 1] == '5' && s[i + 2] <= '5'))
                        {
                            var temp = new List<List<string>>();
                            dp[i + 3, j - 1].ForEach(item => temp.Add(new List<string>(item)));
                            temp.ForEach(str => str.Add(s.Substring(i, 3)));
                            dp[i, j].AddRange(temp);
                        }
                    }
                    else
                    {
                        var l = new List<List<string>>();
                        dp[i + 1, j - 1].ForEach(item => l.Add(new List<string>(item)));
                        l.ForEach(str => str.Add(s.Substring(i, 1)));
                        dp[i, j] = l;

                        if (i <= s.Length - 2)
                        {
                            var temp = new List<List<string>>();
                            dp[i + 2, j - 1].ForEach(item => temp.Add(new List<string>(item)));
                            temp.ForEach(str => str.Add(s.Substring(i, 2)));
                            dp[i, j].AddRange(temp);
                        }
                    }
                }
            }

            return dp[0, 4].Select(str =>
            {
                str.Reverse();
                return String.Join(".", str);
            }).ToList();
        }
    }
}
