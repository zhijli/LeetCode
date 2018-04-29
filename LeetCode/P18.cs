using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class P18
    {
        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            Array.Sort(nums);
            var results = new List<IList<int>>();
            for (int i = 0; i < nums.Length - 3; i++)
            {
                if (i > 0 && nums[i - 1] == nums[i]) continue;

                for (int j = i + 1; j < nums.Length - 2; j++)
                {
                    if (j > i + 1 && nums[j - 1] == nums[j]) continue;

                    int left = j + 1;
                    int right = nums.Length - 1;

                    while (left < right)
                    {
                        int val = nums[i] + nums[j] + nums[left] + nums[right];

                        if (val == target)
                        {
                            results.Add(new List<int> { nums[i], nums[j], nums[left], nums[right] });
                            var temp = nums[left];
                            while (left < right && temp == nums[left])
                            {
                                left++;
                            }
                        }
                        else if (val < target)
                        {
                            left++;
                        }
                        else
                        {
                            right--;
                        }
                    }
                }
            }

            return results;
        }
    }
}
