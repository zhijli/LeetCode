using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class P46
    {
        public IList<IList<int>> Permute(int[] nums)
        {
            return Permute(nums, 0);
        }

        private List<IList<int>> Permute(int[] nums, int index)
        {
            if (index == nums.Length) return new List<IList<int>> {new List<int>()};
            var results = new List<IList<int>>();
            for (int i = index; i < nums.Length; i++)
            {
                Swap(nums, index, i);
                Permute(nums, index + 1).ForEach(item => results.Add(new List<int>(item) { nums[index] }));
                Swap(nums, index, i);
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
