using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class P84
    {
        public int LargestRectangleArea(int[] heights)
        {
            return LargestRectangleArea(heights, 0, heights.Length - 1);
        }

        private int LargestRectangleArea(int[] heights, int left, int right)
        {
            if (left > right) return 0;

            var mid = (left + right) / 2;

            var i = mid;
            var j = mid;
            var min = heights[mid];
            var max = 0;
            while (i >= left && j <= right)
            {
                min = Math.Min(Math.Min(min, heights[i]), heights[j]);
                while (i - 1 >= left && heights[i - 1] >= min) i--;
                while (j + 1 <= right && heights[j + 1] >= min) j++;
                if (min * (j - i + 1) > max)
                {
                    max = min * (j - i + 1);
                }

                if (i == left)
                {
                    j++;
                }
                else if (j == right)
                {
                    i--;
                }
                else
                {
                    if (heights[i - 1] < heights[j + 1])
                    {
                        j++;
                    }
                    else
                    {
                        i--;
                    }
                }

            }

            return Math.Max(Math.Max(max, LargestRectangleArea(heights, left, mid - 1)), LargestRectangleArea(heights, mid + 1, right));
        }
    }
}
