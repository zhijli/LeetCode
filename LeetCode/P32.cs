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
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    class P32
    {
        public int LongestValidParentheses(string s)
        {
            if (s == null || s.Length < 2) return 0;

            var max = 0;
            var longs = new int[s.Length];
            longs[0] = 0;
            if (s[0] == '(' && s[1] == ')')
            {
                longs[1] = 2;
            }
            else
            {
                longs[1] = 0;
            }

            for (int i = 2; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    longs[i] = 0;
                }
                else if (s[i - 1] == '(')
                {
                    longs[i] = longs[i - 2] + 2;
                }
                else if (i - 1 - longs[i - 1] >= 0)
                {
                    if (s[i - 1 - longs[i - 1]] == '(')
                    {
                        if (i - 1 - longs[i - 1] - 1 >= 0)
                        {
                            longs[i] = longs[i - 1] + 2 + longs[i - 1 - longs[i - 1] - 1];
                        }
                        else
                        {
                            longs[i] = longs[i - 1] + 2;
                        }
                    }
                    else
                    {
                        longs[i] = 0;
                    }

                }
                else
                {
                    longs[i] = 0;
                }

            }

            for (int i = 0; i < s.Length; i++)
            {
                if (max < longs[i])
                {
                    max = longs[i];
                }
            }
            return max;
        }
    }
}
