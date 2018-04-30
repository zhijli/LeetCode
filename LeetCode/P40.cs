using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class P40
    {
        private static List<IList<int>>[,] dp;

        public IList<IList<int>> CombinationSum2(int[] candidates, int target)
        {
            dp = new List<IList<int>>[candidates.Length, target + 1];
            Array.Sort(candidates);

            return CombinationSum2(candidates, candidates.Length - 1, target);
        }

        public List<IList<int>> CombinationSum2(int[] candidates, int index, int target)
        {
            if (target == 0) return new List<IList<int>> { new List<int>() };
            if (index < 0) return new List<IList<int>>();
            if (dp[index, target] != null) return dp[index, target];

            var results = new List<IList<int>>();
            for (int i = index; i >= 0; i--)
            {
                if (i < index && candidates[i] == candidates[i + 1]) continue;

                if (target >= candidates[i])
                {
                    CombinationSum2(candidates, i - 1, target - candidates[i]).ForEach(
                    item =>
                    {
                        //Need deep copy
                        results.Add(new List<int>(item) { candidates[i] });
                    });
                }
            }

            dp[index, target] = results;
            return results;
        }
    }
}
