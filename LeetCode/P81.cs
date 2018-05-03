using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class P81
    {
        public bool Search(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0) return false;

            int minIndex = SearchMin(nums, 0, nums.Length - 1);
            return BinSearch(nums, 0, minIndex - 1, target) || BinSearch(nums, minIndex, nums.Length - 1, target);
        }

        private bool BinSearch(int[] nums, int left, int right, int target)
        {
            while (left <= right)
            {
                var mid = (left + right) / 2;

                if (nums[mid] < target)
                {
                    left = mid + 1;
                }
                else if (nums[mid] > target)
                {
                    right = mid - 1;
                }
                else
                {
                    return true;
                }
            }

            return false;
        }

        private int SearchMin(int[] nums, int left, int right)
        {
            if (nums[right] > nums[left]) return left;


            while (left < right - 1)
            {
                if (nums[right] > nums[left]) return left;

                var mid = (left + right) / 2;

                if (nums[mid] < nums[right])
                {
                    right = mid;
                }
                else if (nums[mid] > nums[left])
                {
                    left = mid + 1;
                }
                else
                {
                    if (nums[left] == nums[right])
                    {
                        var min = left;
                        var max = left;
                        for (int i = left; i <= right; i++)
                        {
                            if (nums[i] < nums[min])
                            {
                                min = i;
                            }
                            if (nums[i] >= nums[max])
                            {
                                max = i;
                            }
                        }

                        if (min != left) return min;
                        if (max + 1 <= right) return max + 1;
                        return min;
                    }
                    else if (nums[left] == nums[mid])
                    {
                        left = mid + 1;
                    }
                    else if (nums[right] == nums[mid])
                    {
                        right = mid;
                    }
                }
            }

            if (nums[right] > nums[left]) return left;
            return right;
        }
    }
}
