using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class P16
    {
        public int ThreeSumClosest(int[] nums, int target)
        {
            Array.Sort(nums);
            int result = nums[0] + nums[1] + nums[2];
            int min = Math.Abs(result - target);

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] * 3 > target + min) break;

                int left = i + 1;
                int right = nums.Length - 1;

                while (left < right)
                {
                    var val = nums[i] + nums[left] + nums[right];

                    if (target > val)
                    {
                        if (target - val < min)
                        {
                            min = target - val;
                            result = val;
                        }
                        left++;
                    }
                    else if (target < val)
                    {
                        if (val - target < min)
                        {
                            min = val - target;
                            result = val;
                        }
                        right--;
                    }
                    else
                    {
                        return val;
                    }
                }
            }
            return result;
        }
    }
}
