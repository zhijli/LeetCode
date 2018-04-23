// -----------------------------------------------------------------------
//  <copyright company="Microsoft">
//      Copyright (c) Microsoft Corporation.  All rights reserved.
//  </copyright>
// -----------------------------------------------------------------------

namespace LeetCode
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Remoting.Messaging;
    using System.Text;
    using System.Threading.Tasks;

    class P3_LengthOfLongestSubstring
    {
        public int LengthOfLongestSubstring(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }

            var result = 0;
            var bits = new BitArray(char.MaxValue);

            int i = 0;
            int j = 0;
            for (j = 0; j < s.Length; j++)
            {
                if (bits[s[j]])
                {
                    for (; i <= j; i++)
                    {
                        if (s[i] != s[j])
                        {
                            bits[s[i]] = false;
                        }
                        else
                        {
                            i++;
                            break;
                        }
                    }
                }
                else
                {
                    bits[s[j]] = true;
                    if (j - i + 1 > result)
                    {
                        result = j - i + 1;
                    }
                }
            }

            return result;
        }
    }
}
