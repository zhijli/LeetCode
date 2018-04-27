// -----------------------------------------------------------------------
//  <copyright company="Microsoft">
//      Copyright (c) Microsoft Corporation.  All rights reserved.
//  </copyright>
// -----------------------------------------------------------------------

namespace LeetCode
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class P10
    {
        public bool IsMatch(string s, string p)
        {
            char preChar = ' '; //' ' is not used in s
            bool isMatch = false;
            int i = 0;
            int j = 0;
            while (i < s.Length && j < p.Length)
            {
                if (p[j] == '.' || s[i] == p[j])
                {
                    preChar = p[j];
                    i++;
                    j++;
                }
                else if (p[j] == '*')
                {
                    while (i < s.Length && (s[i] == preChar || preChar == '.'))
                    {
                        if (IsMatch(s.Substring(i - 1, s.Length - i + 1), p.Substring(j, p.Length - j + 1)))
                        {
                            return true;
                        }
                        i++;
                    }
                    j++;
                }
                else
                {
                    if (j + 1 < p.Length && p[j + 1] == '*')
                    {
                        j += 2;
                        preChar = ' ';
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            if (i == s.Length)
            {
                while (j < p.Length)
                {
                    if (j == '*')
                    {
                        j++;
                    }
                    else
                    {
                        if (j + 1 < p.Length && p[j + 1] == '*')
                        {
                            j += 2;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
