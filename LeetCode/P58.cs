using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class P58
    {
        public int LengthOfLastWord(string s)
        {
            if (string.IsNullOrEmpty(s)) return 0;

            int i = s.Length - 1;
            while (i >= 0 && s[i] == ' ')
            {
                i--;
            }

            int j = i;
            while (j >= 0 && s[j] != ' ')
            {
                j--;
            }

            return i - j;
        }
    }
}
