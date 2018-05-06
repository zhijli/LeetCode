using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class P91
    {
        private int?[] dp;

        public int NumDecodings(string s)
        {
            if (string.IsNullOrEmpty(s)) return 0;

            dp = new int?[s.Length];
            return NumDecodings(s, 0);
        }

        private int NumDecodings(string s, int index)
        {
            if (index == s.Length) return 1;
            if (index == s.Length - 1)
            {
                if (s[index] == '0') return 0;
                return 1;
            }

            if (dp[index] != null) return dp[index].Value;


            if (s[index] == '0')
            {
                dp[index] = 0;
                return dp[index].Value;
            }
            if (s[index] == '1')
            {
                dp[index] = NumDecodings(s, index + 1) + NumDecodings(s, index + 2);
                return dp[index].Value;
            }
            if (s[index] == '2')
            {
                if (s[index + 1] - '0' <= 6)
                {
                    dp[index] = NumDecodings(s, index + 1) + NumDecodings(s, index + 2);
                    return dp[index].Value;
                }

                dp[index] = NumDecodings(s, index + 1);
                return dp[index].Value;
            }
            else
            {
                dp[index] = NumDecodings(s, index + 1);
                return dp[index].Value;
            }
        }
    }
}
