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
            var result = new List<IList<int>>();
            var dic = new Dictionary<int, List<int>>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(nums[i]))
                {
                    dic[nums[i]].Add(i);
                }
                else
                {
                    dic.Add(nums[i], new List<int>() { i });
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    var expected = 0 - nums[i] - nums[j];

                    if (dic.ContainsKey(expected))
                    {
                        var indexList = dic[expected];

                        foreach (var index in indexList)
                        {
                            if (index != i && index != j)
                            {
                                var temp = new List<int>() { nums[i], nums[j], nums[index] };
                                temp.Sort();
                                if (!result.Exists(item => item[0] == temp[0] && item[1] == temp[1] && item[2] == temp[2]))
                                {
                                    result.Add(temp);
                                }
                            }
                        }
                    }
                }
            }
            return result;
        }
    }
}
