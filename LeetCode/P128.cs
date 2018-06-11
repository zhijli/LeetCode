// -----------------------------------------------------------------------
//  <copyright company="Microsoft">
//      Copyright (c) Microsoft Corporation.  All rights reserved.
//  </copyright>
// -----------------------------------------------------------------------

namespace LeetCode
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Security.Policy;
    using System.Text;
    using System.Threading.Tasks;

    public class P128
    {
        private int[] _parent;
        private int[] _rank;

        public int LongestConsecutive(int[] nums)
        {
            if (nums == null || nums.Length == 0) return 0;

            var dic = new Dictionary<int, int>();
            _parent = new int[nums.Length];
            _rank = new int[nums.Length];
            var result = 1;

            for (int i = 0; i < nums.Length; i++)
            {
                _parent[i] = i;
                _rank[i] = 1;
                if (!dic.ContainsKey(nums[i]))
                {
                    dic.Add(nums[i], i);
                }
            }

            foreach (int num in nums)
            {
                if (dic.ContainsKey(num - 1))
                {
                    var rank = Union(dic[num], dic[num - 1]);
                    if (rank > result)
                    {
                        result = rank;
                    }
                }
            }

            return result;
        }

        private int Union(int x, int y)
        {
            var xRoot = FindPoot(x);
            var yRoot = FindPoot(y);

            if (xRoot != yRoot)
            {
                if (_rank[xRoot] < _rank[yRoot])
                {
                    _parent[xRoot] = yRoot;
                    _rank[yRoot] += _rank[xRoot];
                    return _rank[yRoot];
                }
                else
                {
                    _parent[yRoot] = xRoot;
                    _rank[xRoot] += _rank[yRoot];
                    return _rank[xRoot];
                }
            }

            return _rank[yRoot];
        }

        private int FindPoot(int x)
        {
            if (x != _parent[x])
            {
                _parent[x] = FindPoot(_parent[x]);
            }
            return _parent[x];
        }
    }
}
