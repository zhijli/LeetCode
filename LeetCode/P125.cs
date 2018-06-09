using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class P125
    {
        public bool IsPalindrome(string s)
        {
            int left = 0;
            int right = s.Length - 1;
            s = s.ToLowerInvariant();
            while (left < right)
            {
                if (!IsAlphanumeric(s[left]))
                {
                    left++;
                    continue;
                }
                if (!IsAlphanumeric(s[right]))
                {
                    right--;
                    continue;
                }

                if (s[left] == s[right])
                {
                    left++;
                    right--;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        bool IsAlphanumeric(char c)
        {
            return (c <= '9' && c >= '0') || (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z');
        }
    }
}
