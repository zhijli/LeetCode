using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class P39
    {
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            Array.Sort(candidates);

            List<IList<int>>[,] dp = new List<IList<int>>[candidates.Length, target + 1];
            for (int i = 0; i < candidates.Length; i++)
            {
                dp[i, 0] = new List<IList<int>>();
            }

            for (int val = 0; val <= target; val++)
            {
                for (int i = 0; i < candidates.Length; i++)
                {
                    for (int k = 0; k <= i; k++)
                    {
                        if (val >= candidates[k])
                        {
                            if (dp[k, val - candidates[k]] != null)
                            {
                                //Need Deep copy for each list
                                var list = new List<List<int>>();
                                dp[k, val - candidates[k]].ForEach(result => list.Add(new List<int>(result)));

                                list.ForEach(result => result.Add(candidates[k]));
                                if (list.Count == 0)
                                {
                                    list.Add(new List<int> { candidates[k] });
                                }

                                if (dp[i, val] == null)
                                {
                                    dp[i, val] = new List<IList<int>>();
                                }
                                dp[i, val].AddRange(list);
                            }
                        }
                    }
                }
            }

            if (dp[candidates.Length - 1, target] == null)
            {
                return new List<IList<int>>();
            }
            return dp[candidates.Length - 1, target];
        }
    }
}
