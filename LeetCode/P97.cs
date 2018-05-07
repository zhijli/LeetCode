using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class P97
    {
        private bool?[,,] dp;
        public bool IsInterleave(string s1, string s2, string s3)
        {
            dp = new bool?[s1.Length + 1, s2.Length + 1, s3.Length + 1];
            return IsInterleave(s1, 0, s2, 0, s3, 0);
        }

        private bool IsInterleave(string s1, int v1, string s2, int v2, string s3, int v3)
        {
            if (v1 == s1.Length && v2 == s2.Length && v3 == s3.Length) return true;
            if (v3 == s3.Length) return false;
            if (dp[v1, v2, v3] != null) return dp[v1, v2, v3].Value;

            if (v1 <= s1.Length - 1 && s1[v1] == s3[v3] && IsInterleave(s1, v1 + 1, s2, v2, s3, v3 + 1))
            {
                dp[v1, v2, v3] = true;
                return true;
            }
            if (v2 <= s2.Length - 1 && s2[v2] == s3[v3] && IsInterleave(s1, v1, s2, v2 + 1, s3, v3 + 1))
            {
                dp[v1, v2, v3] = true;
                return true;
            }

            dp[v1, v2, v3] = false;
            return false;
        }
    }
}
