using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class P45
    {
        public int Jump(int[] nums)
        {
            if (nums == null || nums.Length <= 1) return 0;
            int i = 0;
            int max = i + 1;
            int step = 0;

            while (i < nums.Length)
            {
                if (i + nums[i] >= nums.Length - 1)
                {
                    return step + 1;
                }
                else
                {
                    max = i + 1;
                    for (int j = max + 1; j <= i + nums[i]; j++)
                    {
                        if (nums[j] + j > nums[max] + max)
                        {
                            max = j;
                        }
                    }
                    i = max;
                    step++;
                }
            }
            return step;
        }
    }
}
