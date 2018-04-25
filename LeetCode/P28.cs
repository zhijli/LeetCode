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

    class P28
    {
        public int StrStr(string haystack, string needle)
        {
            if (needle == string.Empty) return 0;

            int i = 0;
            int j = 0;
            for (i = 0; i < haystack.Length - needle.Length + 1; i++)
            {
                for (j = 0; j < needle.Length; j++)
                {
                    if (haystack[i + j] != needle[j])
                    {
                        break;
                    }
                }

                if (j == needle.Length)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
