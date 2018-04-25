using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class P34
    {
        public int[] SearchRange(int[] nums, int target)
        {
            int left = SearchLeft(nums, 0, nums.Length - 1, target);
            int right = SearchRight(nums, 0, nums.Length - 1, target);

            return new[] { left, right };
        }

        private int SearchRight(int[] nums, int begin, int end, int target)
        {
            if (end < begin) return -1;

            int mid = (end + begin) / 2;

            if (nums[mid] < target)
            {
                return SearchRight(nums, mid + 1, end, target);
            }
            else if (nums[mid] > target)
            {
                return SearchRight(nums, begin, mid - 1, target);
            }
            else
            {

                if (mid + 1 <= end && nums[mid + 1] == target)
                {
                    return SearchRight(nums, mid + 1, end, target);
                }
                else
                {
                    return mid;
                }
            }
        }

        private int SearchLeft(int[] nums, int begin, int end, int target)
        {
            if (end < begin) return -1;

            int mid = (end + begin) / 2;

            if (nums[mid] < target)
            {
                return SearchLeft(nums, mid + 1, end, target);
            }
            else if (nums[mid] > target)
            {
                return SearchLeft(nums, begin, mid - 1, target);
            }
            else
            {

                if (mid - 1 >= begin && nums[mid - 1] == target)
                {
                    return SearchLeft(nums, begin, mid - 1, target);
                }
                else
                {
                    return mid;
                }
            }
        }
    }
}
