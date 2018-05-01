using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class P55
    {
        public bool CanJump(int[] nums)
        {
            int i = 0;
            int maxIndex = 0;

            while (i < nums.Length - 1)
            {
                if (nums[i] == 0) return false;
                if (i + nums[i] >= nums.Length - 1) return true;
                for (int j = maxIndex + 1; j <= i + nums[i]; j++)
                {
                    if (nums[j] + j >= maxIndex + nums[maxIndex])
                    {
                        maxIndex = j;
                    }
                }
                i = maxIndex;
            }

            return true;
        }
    }
}
