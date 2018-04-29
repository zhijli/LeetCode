// -----------------------------------------------------------------------
//  <copyright company="Microsoft">
//      Copyright (c) Microsoft Corporation.  All rights reserved.
//  </copyright>
// -----------------------------------------------------------------------

namespace LeetCode
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class P15_3Sum
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            if (nums == null || nums.Length == 0) return new List<IList<int>>();
            Array.Sort(nums);

            var result = new List<IList<int>>();
            var dic = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(nums[i]))
                {
                    dic[nums[i]] = i;
                }
                else
                {
                    dic.Add(nums[i], i);
                }
            }

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (i >= 1 && nums[i] == nums[i - 1]) continue;
                if (nums[i] > 0) break;

                int right = nums.Length - 1;
                for (int j = i + 1; j < right; j++)
                {
                    if (j > i + 1 && nums[j] == nums[j - 1]) continue;

                    var expected = 0 - nums[i] - nums[j];
                    if (dic.ContainsKey(expected))
                    {
                        var index = dic[expected];
                        if (index > j)
                        {
                            var temp = new List<int>() { nums[i], nums[j], nums[index] };
                            result.Add(temp);
                            right = index;
                        }
                    }
                }
            }

            return result;
        }
    }
}
