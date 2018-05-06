using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class P78
    {
        public IList<IList<int>> Subsets(int[] nums)
        {
            var result = new List<IList<int>>();
            var current = new List<int>();
            Subsets(nums, 0, current, result);
            return result;
        }

        private void Subsets(int[] nums, int index, List<int> current, List<IList<int>> result)
        {
            if (index == nums.Length)
            {
                result.Add(new List<int>(current));
                return;
            }

            current.Add(nums[index]);
            Subsets(nums, index + 1, current, result);
            current.Remove(nums[index]);

            Subsets(nums, index + 1, current, result);
        }
    }
}
