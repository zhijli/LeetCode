using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class P57
    {
        public IList<Interval> Insert(IList<Interval> intervals, Interval newInterval)
        {
            if(intervals == null || intervals.Count ==0) return new List<Interval> {newInterval};

            var result = new List<Interval>();
            int start = newInterval.start;
            int end = newInterval.end;
            bool isInserted = false;
            foreach (Interval interval in intervals)
            {
                if (interval.end < newInterval.start)
                {
                    result.Add(interval);
                    continue;
                }

                if ( interval.start > newInterval.end)
                {
                    if (isInserted == false)
                    {
                        result.Add(new Interval(start, end));
                        isInserted = true;
                    }

                    result.Add(interval);
                    continue;
                }

                if (interval.start < start)
                {
                    start = interval.start;
                }

                if (interval.end > end)
                {
                    end = interval.end;
                }
            }

            if (isInserted == false)
            {
                result.Add(new Interval(start, end));
            }

            return result;
        }
    }
}
