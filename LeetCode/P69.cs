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

    class P69
    {
        public int MySqrt(int x)
        {
            if (x == 0) return 0;
            long result = x;

            while (result * result > x)
            {
                result = (result + x / result) / 2;
            }
            return (int)result;
        }
    }
}
