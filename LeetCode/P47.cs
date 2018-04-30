using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LeetCode
{
    public class P47
    {
        public IList<IList<int>> PermuteUnique(int[] nums)
        {
            return PermuteUnique(nums, 0);
        }

        private List<IList<int>> PermuteUnique(int[] nums, int v)
        {
            if (v == nums.Length) return new List<IList<int>> { new List<int>() };

            var dic = new Dictionary<int, bool>();

            var results = new List<IList<int>>();
            for (int i = v; i < nums.Length; i++)
            {
                if (!dic.ContainsKey(nums[i]))
                {
                    Swap(nums, v, i);
                    PermuteUnique(nums, v + 1).ForEach(item => results.Add(new List<int>(item) { nums[v] }));
                    Swap(nums, v, i);
                    dic.Add(nums[i], true);
                }
            }
            return results;
        }

        private void Swap(int[] nums, int v, int i)
        {
            var temp = nums[v];
            nums[v] = nums[i];
            nums[i] = temp;
        }
    }
}
