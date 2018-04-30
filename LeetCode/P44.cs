using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class P44
    {
        private bool?[,] dp;

        public bool IsMatch(string s, string p)
        {
            dp = new bool?[s.Length, p.Length];
            return IsMatch(s, 0, p, 0);
        }

        private bool IsMatch(string s, int v1, string p, int v2)
        {
            if (v1 == s.Length)
            {
                for (int i = v2; i < p.Length; i++)
                {
                    if (p[i] != '*')
                    {
                        return false;
                    }
                }
                return true;
            }
            if (v2 == p.Length) return false;
            if (dp[v1, v2] != null) return dp[v1, v2].Value;
            
            if (s[v1] == p[v2] || p[v2] == '?')
            {
                dp[v1, v2] = IsMatch(s, v1 + 1, p, v2 + 1);
                return dp[v1, v2].Value;
            }
            if (p[v2] == '*')
            {
                dp[v1, v2] = IsMatch(s, v1 + 1, p, v2) || IsMatch(s, v1, p, v2 + 1);
                return dp[v1, v2].Value;
            }

            dp[v1, v2] = false;
            return false;
        }
    }
}
