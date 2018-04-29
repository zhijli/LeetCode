using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class P33
    {
        public int Search(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0) return -1;

            int index = FindBreakpoint(nums, 0, nums.Length - 1);

            var result = BinSearch(nums, 0, index - 1, target);
            if (result == -1)
            {
                return BinSearch(nums, index, nums.Length - 1, target);
            }

            return result;
        }

        private int BinSearch(int[] nums, int left, int right, int target)
        {
            if (left > right) return -1;

            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (nums[mid] > target)
                {
                    right = mid - 1;
                }
                else if (nums[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    return mid;
                }
            }

            return -1;
        }

        private int FindBreakpoint(int[] nums, int left, int right)
        {
            if (right < left) throw new Exception("Right index is less than Left index");
            if (nums[left] < nums[right]) return left;

            int mid = (left + right) / 2;
            while (left < right - 1)
            {
                mid = (left + right) / 2;

                if (nums[mid] > nums[left])
                {
                    left = mid;
                }
                else if (nums[mid] < nums[right])
                {
                    right = mid;
                }
            }

            return right;
        }
    }
}
