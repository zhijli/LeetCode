using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class P41
    {
        public int FirstMissingPositive(int[] nums)
        {
            if (nums == null || nums.Length == 0) return 1;
            if (nums.Length == 1)
            {
                if (nums[0] == 1)
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                while (nums[i] >= 1 && nums[i] <= nums.Length && nums[i] != nums[nums[i] - 1])
                {
                    var temp = nums[i];
                    nums[i] = nums[nums[i] - 1];
                    nums[temp - 1] = temp;
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != i + 1)
                    return i + 1;
            }

            return nums.Length + 1;
        }
    }
}
