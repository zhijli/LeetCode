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
            int i = 0;
            int j = 0;
            while (i < s.Length && j < p.Length)
            {
                if (j + 1 < p.Length && p[j + 1] == '*')
                {
                    if (j + 2 < p.Length)
                    {
                        i--;
                        do
                        {
                            i++;
                            if (i < s.Length && IsMatch(s.Substring(i, s.Length - i), p.Substring(j + 2, p.Length - j - 2)))
                            {
                                return true;
                            }
                        } while (i < s.Length && (s[i] == p[j] || p[j] == '.'));
                        j += 2;
                    }
                    else
                    {
                        while (i < s.Length && (s[i] == p[j] || p[j] == '.'))
                        {
                            i++;
                        }
                        j += 2;
                    }
                }
                else if (s[i] == p[j] || p[j] == '.')
                {
                    i++;
                    j++;
                }
                else
                {
                    return false;
                }
            }

            if (i == s.Length)
            {
                if (j == p.Length)
                {
                    return true;
                }
                else
                {
                    if (p[j] == '*')
                    {
                        j++;
                    }
                    while (j < p.Length)
                    {
                        if (j + 1 < p.Length && p[j + 1] == '*')
                        {
                            j += 2;
                        }
                        else { return false; }
                    }
                    return true;
                }

            }
            else
            {
                return false;
            }
        }
    }
}

