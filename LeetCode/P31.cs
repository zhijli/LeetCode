using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class P31
    {
        public void NextPermutation(int[] nums)
        {
            if (nums == null || nums.Length <= 1) return;

            int i;
            for (i = nums.Length - 1; i > 0; i--)
            {
                if (nums[i - 1] < nums[i])
                    break;
            }
            if (i > 0)
            {
                i--;
                int j;

                for (j = i + 1; j < nums.Length - 1; j++)
                {
                    if (nums[j + 1] <= nums[i])
                    {
                        break;
                    }
                }

                var temp = nums[j];
                nums[j] = nums[i];
                nums[i] = temp;

                QuickSort(nums, i + 1, nums.Length - 1);
            }
            else
            {
                QuickSort(nums, 0, nums.Length - 1);
            }
        }

        private void QuickSort(int[] nums, int begin, int end)
        {
            if (end <= begin)
                return;

            int i = begin;
            int j = begin;
            int temp;
            while (j <= end)
            {
                if (nums[j] < nums[begin])
                {
                    i++;
                    temp = nums[j];
                    nums[j] = nums[i];
                    nums[i] = temp;
                }
                j++;
            }

            temp = nums[i];
            nums[i] = nums[begin];
            nums[begin] = temp;
            QuickSort(nums, begin, i - 1);
            QuickSort(nums, i + 1, end);
        }
    }
}
