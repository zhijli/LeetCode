using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class P56
    {
        public IList<Interval> Merge(IList<Interval> intervals)
        {
            int n = intervals.Count;
            var start = new List<int>();
            var end = new List<int>();
            foreach (Interval inter in intervals)
            {
                start.Add(inter.start);
                end.Add(inter.end);
            }

            start.Sort();
            end.Sort();

            var result = new List<Interval>();
            int j = 0;
            for (int i = 0; i < n; i++)
            {
                if (i == n - 1 || start[i + 1] > end[i])
                {
                    result.Add(new Interval(start[j], end[i]));
                    j = i + 1;
                }
            }

            return result;
        }
    }
}
