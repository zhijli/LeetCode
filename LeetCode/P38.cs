// -----------------------------------------------------------------------
//  <copyright company="Microsoft">
//      Copyright (c) Microsoft Corporation.  All rights reserved.
//  </copyright>
// -----------------------------------------------------------------------

namespace LeetCode
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlTypes;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class P38
    {
        public string CountAndSay(int n)
        {
            var current = "1";
            string next = null;

            for (int i = 1; i < n; i++)
            {
                next = GetNext(current);
                current = next;
            }

            return current;
        }

        private string GetNext(string str)
        {
            var result = new StringBuilder();
            var count = 1;
            char current = str[0];
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] != current)
                {
                    result.Append(count.ToString());
                    result.Append(current);
                    current = str[i];
                    count = 1;
                }
                else
                {
                    count++;
                }
            }

            result.Append(count.ToString());
            result.Append(current);

            return result.ToString();
        }
    }
}
