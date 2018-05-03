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

    public class P80
    {
        public int RemoveDuplicates(int[] nums)
        {
            int i = 0, j = 0, count = 1;

            for (; j < nums.Length; j++)
            {
                if (j > 0 && nums[j] == nums[j - 1])
                {
                    count++;
                    if (count <= 2)
                    {
                        nums[i++] = nums[j];
                    }
                }
                else
                {
                    nums[i++] = nums[j];
                    count = 1;
                }
            }

            return i;
        }
    }
}
