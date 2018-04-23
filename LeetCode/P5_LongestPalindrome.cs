using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class P5_LongestPalindrome
    {
        public string LongestPalindrome(string s)
        {
            if (s == null) return null;
            var result = string.Empty;
            int i = 0;
            int j = 0;
            int max = 0;
            for (; i < s.Length; i++)
            {
                j = 0;
                while (i + j < s.Length && i - j >= 0)
                {
                    if (s[i + j] == s[i - j])
                    {
                        if (2 * j + 1 >= max)
                        {
                            result = s.Substring(i - j, 2 * j + 1);
                            max = 2 * j + 1;
                        }
                        j++;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            i = 0;
            for (; i < s.Length - 1; i++)
            {
                j = 0;
                while (i + 1 + j < s.Length && i - j >= 0)
                {
                    if (s[i + j + 1] == s[i - j])
                    {
                        if (2 * j + 2 >= max)
                        {
                            result = s.Substring(i - j, 2 * j + 2);
                            max = 2 * j + 2;
                        }
                        j++;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return result;
        }
    }
}
