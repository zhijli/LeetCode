namespace LeetCode
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class P132
    {
        private int?[] dp;

        public int MinCut(string s)
        {
            if (string.IsNullOrEmpty(s)) return 0;

            dp = new int?[s.Length];
            return MinCut(s, 0);
        }

        private int MinCut(string s, int index)
        {
            if (index == s.Length) return -1;
            if (index == s.Length - 1) return 0;
            if (dp[index] != null) return dp[index].Value;

            var result = int.MaxValue;
            for (int i = index; i < s.Length; i++)
            {
                if (IsPalindrome(s.Substring(index, i - index + 1)))
                {
                    result = Math.Min(result, MinCut(s, i + 1) + 1);
                }
            }
            dp[index] = result;
            return result;
        }

        private bool IsPalindrome(string s)
        {
            var left = 0;
            var right = s.Length - 1;

            while (left < right)
            {
                if (s[left] != s[right]) return false;
                left++;
                right--;
            }
            return true;
        }
    }
}
