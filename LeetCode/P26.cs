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

    class P26
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums == null || nums.Length == 0) return 0;

            var index = 0;
            int currentNum = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (currentNum != nums[i])
                {
                    nums[++index] = nums[i];
                    currentNum = nums[i];
                }
            }
            return index + 1;
        }
    }
}
