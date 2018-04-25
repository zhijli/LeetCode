using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class P35
    {
        public int SearchInsert(int[] nums, int target)
        {
            return SearchInsert(nums, 0, nums.Length - 1, target);
        }

        private int SearchInsert(int[] nums, int begin, int end, int target)
        {
            int mid = (begin + end) / 2;

            if (nums[mid] == target)
            {
                return mid;
            }
            if (nums[mid] > target)
            {
                if (mid == begin)
                {
                    return mid;
                }
                return SearchInsert(nums, begin, mid - 1, target);
            }
            else
            {
                if (mid == end)
                {
                    return mid + 1;
                }
                return SearchInsert(nums, mid + 1, end, target);
            }
        }
    }
}
