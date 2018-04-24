using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class P9_PalindromeNumber
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0) return false;
            var str = x.ToString();
            int i = 0;
            int j = str.Length - 1;
            while (i <= j && str[i] == str[j])
            {
                i++;
                j--;
            }
            if (i > j)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
