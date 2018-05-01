// -----------------------------------------------------------------------
//  <copyright company="Microsoft">
//      Copyright (c) Microsoft Corporation.  All rights reserved.
//  </copyright>
// -----------------------------------------------------------------------

namespace LeetCode
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml.XPath;

    class P12_IntegerToRoman
    {
        public string IntToRoman(int num)
        {
            var romanChar = "IVXLCDMNN";
            var result = new StringBuilder();
            int j = 0;
            int k = 0;
            while (num > 0)
            {
                k = num % 10;
                num = num / 10;

                var x = k % 5;
                var y = k / 5;

                if (x == 0)
                {
                    if (y == 1)
                    {
                        result.Append(romanChar[j + 1]);
                    }
                }
                else if (x == 4)
                {
                    result.Append(romanChar[j + 1 + y]);
                    result.Append(romanChar[j]);
                }
                else
                {
                    result.Append(romanChar[j], x);
                    if (y == 1)
                    {
                        result.Append(romanChar[j + 1]);
                    }
                }

                j += 2;
            }

            return Reverse(result.ToString());
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}