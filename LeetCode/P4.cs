// -----------------------------------------------------------------------
//  <copyright company="Microsoft">
//      Copyright (c) Microsoft Corporation.  All rights reserved.
//  </copyright>
// -----------------------------------------------------------------------

namespace LeetCode
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class P4
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int count = nums1.Length + nums2.Length;

            if (count % 2 == 0)
            {
                return FindN(nums1, nums2, count / 2);
            }
            else
            {
                return (FindN(nums1, nums2, count / 2) + FindN(nums1, nums2, count / 2 + 1)) / 2.0;
            }
        }

        private int FindN(int[] nums1, int[] nums2, int n)
        {
            int max = Math.Max(nums1[nums1.Length - 1], nums2[nums2.Length - 1]);
            int min = Math.Min(nums1[0], nums2[0]);
            int mid = (max + min) / 2;

            var index = SearchInsert(nums1, nums2, mid);
            while (index != n)
            {
                if (index > n)
                {
                    mid = (min + mid) / 2;
                    index = SearchInsert(nums1, nums2, mid);
                }
                else
                {
                    mid = (max + mid) / 2;
                    index = SearchInsert(nums1, nums2, mid);
                }
            }

            return mid;
        }

        private int SearchInsert(int[] nums1, int[] nums2, int mid)
        {
            return SearchInsert(nums1, mid) + SearchInsert(nums2, mid);

        }

        private int SearchInsert(int[] nums, int target)
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
