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

    class P67
    {
        public string AddBinary(string a, string b)
        {
            int i = a.Length - 1;
            int j = b.Length - 1;
            var result = "";
            int op = 0;
            for (; i >= 0 && j >= 0; i--, j--)
            {
                var val = a[i] - '0' + b[j] - '0' + op;
                op = val / 2;
                val = val % 2;
                result = (char)(val + '0') + result;
            }

            for (; i >= 0; i--)
            {
                var val = a[i] - '0' + op;
                op = val / 2;
                val = val % 2;
                result = (char)(val + '0') + result;
            }
            for (; j >= 0; j--)
            {
                var val = b[j] - '0' + op;
                op = val / 2;
                val = val % 2;
                result = (char)(val + '0') + result;
            }
            if (op > 0)
            {
                result = (char)(op + '0') + result;
            }
            return result;
        }
    }
}
