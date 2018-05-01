using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class P60
    {
        private int[] s;

        public string GetPermutation(int n, int k)
        {
            if (n == 0) return "";
            if (n == 1) return "1";

            if (s == null)
            {
                s = new int[n + 1];
                s[1] = 1;
                for (int i = 2; i <= n; i++)
                {
                    s[i] = s[i - 1] * i;
                }
            }

            int val = ((k - 1) / s[n - 1] + 1);
            var next = k % s[n - 1];
            var temp = GetPermutation(n - 1, next == 0 ? s[n - 1] : next);
            var sb = new StringBuilder();
            foreach (char c in temp)
            {
                if (c - '0' >= val)
                {
                    sb.Append((char)(c + 1));
                }
                else
                {
                    sb.Append(c);
                }
            }
            return val + sb.ToString();
        }
    }
}
