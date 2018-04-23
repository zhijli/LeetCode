using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class P6_ZigZagConversion
    {
        public string Convert(string s, int numRows)
        {
            if (s == null || numRows < 2)
                return s;

            int i = 0;
            int j = 0;
            var result = new StringBuilder();

            for (; i < numRows; i++)
            {
                for (j = 0; j * (2 * numRows - 2) + i < s.Length; j++)
                {
                    result.Append(s[j * (2 * numRows - 2) + i]);
                    if (i != 0 && i != numRows - 1 && (j + 1) * (2 * numRows - 2) - i < s.Length)
                    {
                        result.Append(s[(j + 1) * (2 * numRows - 2) - i]);
                    }
                }
            }

            return result.ToString();
        }
    }
}
