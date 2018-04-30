using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class P39
    {
        static List<IList<int>>[,] dp;

        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            dp = new List<IList<int>>[candidates.Length, target + 1];
            return CombinationSum(candidates, candidates.Length - 1, target);
        }

        private List<IList<int>> CombinationSum(int[] candidates, int index, int target)
        {
            if (target == 0) return new List<IList<int>> { new List<int>() };
            if (dp[index, target] != null) return dp[index, target];

            var results = new List<IList<int>>();
            for (int i = 0; i <= index; i++)
            {
                if (target >= candidates[i])
                {
                    CombinationSum(candidates, i, target - candidates[i]).ForEach(
                        item =>
                        {
                            //Need Deep copy for each list
                            results.Add(new List<int>(item) { candidates[i] });
                        });
                }
            }

            dp[index, target] = results;
            return results;
        }
    }
}
