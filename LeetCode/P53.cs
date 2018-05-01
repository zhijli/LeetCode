using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class P53
    {
        public int MaxSubArray(int[] nums)
        {
            int max = nums[0];
            int[] dp = new int[nums.Length];
            dp[0] = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (dp[i - 1] < 0)
                {
                    dp[i] = nums[i];
                }
                else
                {
                    dp[i] = dp[i - 1] + nums[i];
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (max < dp[i]) max = dp[i];
            }
            return max;
        }
    }
}
