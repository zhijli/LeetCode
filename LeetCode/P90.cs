using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class P90
    {
        public IList<IList<int>> SubsetsWithDup(int[] nums)
        {
            var result = new List<IList<int>>();
            var current = new List<int>();
            Array.Sort(nums);
            var dic = new Dictionary<string, bool>();
            var str = string.Empty;
            SubsetsWithDup(nums, 0, dic, current, str, result);
            return result;
        }

        private void SubsetsWithDup(int[] nums, int index, Dictionary<string, bool> dic, List<int> current, string str, List<IList<int>> result)
        {
            if (index == nums.Length)
            {
                result.Add(new List<int>(current));
                return;
            }

            if (!dic.ContainsKey(str + nums[index]))
            {
                current.Add(nums[index]);
                dic.Add(str + nums[index], true);
                SubsetsWithDup(nums, index + 1, dic, current, str + nums[index], result);
                current.Remove(nums[index]);
            }

            SubsetsWithDup(nums, index + 1, dic, current, str, result);
        }
    }
}
