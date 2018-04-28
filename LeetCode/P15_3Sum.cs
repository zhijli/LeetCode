// -----------------------------------------------------------------------
//  <copyright company="Microsoft">
//      Copyright (c) Microsoft Corporation.  All rights reserved.
//  </copyright>
// -----------------------------------------------------------------------

namespace LeetCode
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class P15_3Sum
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            if (nums == null || nums.Length == 0) return new List<IList<int>>();

            var lists = nums.ToList();
            lists.Sort();
            nums = lists.ToArray();

            var max = nums[nums.Length - 1];

            var result = new List<IList<int>>();
            var dic = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(nums[i]))
                {
                    dic[nums[i]] = i;
                }
                else
                {
                    dic.Add(nums[i], i);
                }
            }

            int right = nums.Length - 1;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (i >= 1 && nums[i] == nums[i - 1]) continue;
                if (nums[i] > 0) break;
                //int left = FindRightIndex(nums, i + 1, nums.Length - 1, 0 - nums[i] - max);
                for (int j = i + 1; j < nums.Length; j++)
                {
                    var expected = 0 - nums[i] - nums[j];
                    if (dic.ContainsKey(expected))
                    {
                        var index = dic[expected];
                        if (index != i && index != j)
                        {
                            var temp = new List<int>() { nums[i], nums[j], nums[index] };
                            result.Add(temp);
                            right = index - 1;
                        }
                    }
                }
            }

            return result.Distinct(new MyEqualityComparer()).ToList();
        }

        private int FindRightIndex(int[] nums, int begin, int end, int target)
        {
            int mid = (begin + end) / 2;

            while (begin < end - 1)
            {
                mid = (begin + end) / 2;

                if (nums[mid] > target)
                {
                    end = mid;
                }
                if (nums[mid] < target)
                {
                    begin = mid + 1;
                }
                if (nums[mid] == target)
                {
                    begin = mid;
                }
            }

            if (begin == end - 1)
            {
                if (nums[end] <= target)
                {
                    return end;
                }
                else if (nums[begin] >= target)
                {
                    return begin;
                }
                else
                {
                    return end;
                }
            }

            return begin;
        }

        private int FindLeftIndex(int[] nums, int begin, int end, int target)
        {
            int mid = (begin + end) / 2;

            while (begin < end - 1)
            {
                mid = (begin + end) / 2;

                if (nums[mid] >= target)
                {
                    end = mid - 1;
                }
                if (nums[mid] < target)
                {
                    begin = mid;
                }
            }

            if (begin == end - 1)
            {
                if (nums[begin] >= target)
                {
                    return begin;
                }
                else if (nums[end] <= target)
                {
                    return end;
                }
                else
                {
                    return begin;
                }
            }

            return begin;
        }
    }

    internal class MyEqualityComparer : IEqualityComparer<IList<int>>
    {
        public bool Equals(IList<int> x, IList<int> y)
        {
            if (x.Count == y.Count)
            {
                var x1 = x.ToList();
                x1.Sort();
                var y1 = y.ToList();
                y1.Sort();
                for (int i = 0; i < x1.Count; i++)
                {
                    if (x1[i] != y1[i])
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public int GetHashCode(IList<int> obj)
        {
            if (obj.Count > 0)
            {
                var result = obj[0].GetHashCode();

                for (int i = 1; i < obj.Count; i++)
                {
                    result ^= obj[i];
                }
                return result;
            }
            return obj.GetHashCode();
        }
    }
}
