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
    using System.Runtime.InteropServices.WindowsRuntime;
    using System.Text;
    using System.Threading.Tasks;

    class P27
    {
        public int RemoveElement(int[] nums, int val)
        {
            if (nums == null) return 0;

            int j = nums.Length - 1;

            while (j >= 0 && nums[j] == val)
            {
                j--;
            }

            for (int i = j - 1; i >= 0; i--)
            {
                if (nums[i] == val)
                {
                    nums[i] = nums[j];
                    nums[j] = val;
                    j--;
                }
            }

            return j + 1;
        }
    }
}
