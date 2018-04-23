using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    using System.Collections;

    public class P1_TwoSum
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var table = new Dictionary<int, int>();

            for (var i = 0; i < nums.Length; i++)
            {
                if (table.ContainsKey(target - nums[i]))
                {
                    var j = table[target - nums[i]];
                    if (i != j)
                    {
                        return new[] { j, i };
                    }
                }
                else
                {
                    table[nums[i]] = i;
                }
            }

            return null;
        }
    }
}
