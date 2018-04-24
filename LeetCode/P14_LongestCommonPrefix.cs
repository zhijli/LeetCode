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

    class P14_LongestCommonPrefix
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if(strs == null || strs.Length == 0) return String.Empty;

            var sb = new StringBuilder();

            var minLenght = strs.Select(s => s.Length).Min(length => length);

            for(int i =0 ; i <minLenght; i++)
            {
                for (int j = 1; j < strs.Length; j++)
                {
                    if (strs[0][i] != strs[j][i])
                        return sb.ToString();
                }
                sb.Append(strs[0][i]);
            }
            return sb.ToString();
        }
    }
}
