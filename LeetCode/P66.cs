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

    class P66
    {
        public int[] PlusOne(int[] digits)
        {
            if (digits == null || digits.Length == 0) return new int[] { 1 };
            var list = new List<int>();
            int remainder = 0;
            int quotient = 0;

            for (int i = digits.Length - 1; i >= 0; i--)
            {
                var val = digits[i] + quotient;
                if (i == digits.Length - 1)
                {
                    val++;
                }
                remainder = val % 10;
                quotient = val / 10;
                list.Add(remainder);
            }
            if (quotient != 0)
            {
                list.Add(quotient);
            }

            int[] result = new int[list.Count];
            for (int i = list.Count - 1; i >= 0; i--)
            {
                result[list.Count - 1 - i] = list[i];
            }
            return result;
        }
    }
}
