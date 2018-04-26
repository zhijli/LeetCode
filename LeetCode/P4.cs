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

    public class P4
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            if (nums1 == null || nums1.Length == 0)
            {
                if (nums2.Length % 2 == 1)
                {
                    return nums2[(nums2.Length) / 2];
                }
                else
                {
                    return (nums2[(nums2.Length / 2)] + nums2[nums2.Length / 2 - 1]) / 2.0;
                }
            }
            if (nums2 == null || nums2.Length == 0)
            {
                if (nums1.Length % 2 == 1)
                {
                    return nums1[(nums1.Length) / 2];
                }
                else
                {
                    var num1 = nums1[(nums1.Length / 2)];
                    var num2 = nums1[nums1.Length / 2 - 1];
                    return (num1 + num2) / 2.0;
                }
            }

            int count = nums1.Length + nums2.Length;

            if (count % 2 == 1)
            {
                return FindN(nums1, nums2, (count + 1) / 2);
            }
            else
            {
                var num1 = FindN(nums1, nums2, count / 2);
                var num2 = FindN(nums1, nums2, count / 2 + 1);
                return (num1 + num2) / 2.0;
            }
        }

        private int FindN(int[] nums1, int[] nums2, int n)
        {
            return FindN(nums1, 0, nums1.Length - 1, nums2, 0, nums2.Length - 1, n);
        }

        private int FindN(int[] nums1, int begin1, int end1, int[] nums2, int begin2, int end2, int n)
        {
            if (end1 - begin1 <= 1 && end2 - begin2 <= 2)
            {
                var temp = new List<int>();
                for (int i = begin1; i <= end1; i++)
                {
                    temp.Add(nums1[i]);
                }
                for (int i = begin2; i <= end2; i++)
                {
                    temp.Add(nums2[i]);
                }
                temp.Sort();
                return temp[n - 1];
            }

            int mid1 = (begin1 + end1) / 2;
            int mid2 = SearchInsert(nums2, begin2, end2, nums1[mid1]);

            int number = mid1 - begin1 + mid2 - begin2 + 1;

            if (number == n)
            {
                return nums1[mid1];
            }
            else if (number > n)
            {
                if (mid2 > end2)
                {
                    //this means all num in nums2 is less than nums1[mid1]
                    return FindN(nums2, begin2, end2, nums1, begin1, mid1, n);
                }
                //swap nums1 and nums2
                return FindN(nums2, begin2, mid2, nums1, begin1, mid1, n);
            }
            else
            {
                if (mid2 > end2)
                {
                    //this means all num in nums2 is less than nums1[mid1]
                    return FindN(nums2, end2, end2, nums1, mid1, end1, n - number + 2);
                }
                //swap nums1 and nums2
                return FindN(nums2, mid2, end2, nums1, mid1, end1, n - number + 1);
            }
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
