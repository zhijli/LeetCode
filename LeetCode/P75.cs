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

    class P75
    {
        public void SortColors(int[] nums)
        {
            int i = 0, j = 0, k = 0;

            while (k < nums.Length)
            {
                if (nums[k] == 0)
                {
                    Swap(nums, i, k);
                    i++;
                    if (i > j) j = i;
                    if (i > k) k = i;
                }
                else if (nums[k] == 1)
                {
                    Swap(nums, j, k);
                    j++;
                    if (j > k) k = j;
                }
                else
                {
                    k++;
                }
            }
        }

        private void Swap(int[] nums, int i, int k)
        {
            var temp = nums[i];
            nums[i] = nums[k];
            nums[k] = temp;
        }
    }
}
