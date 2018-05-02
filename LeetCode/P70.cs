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

    class P70
    {
        public int ClimbStairs(int n)
        {
            if (n == 1) return 1;
            if (n == 2) return 2;

            int f1 = 1;
            int f2 = 2;

            for (int i = 3; i <= n; i++)
            {
                var temp = f2;
                f2 = f1 + f2;
                f1 = temp;
            }

            return f2;
        }
    }
}
