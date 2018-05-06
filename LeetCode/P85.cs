using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class P85
    {
        public int MaximalRectangle(char[,] matrix)
        {
            var row = matrix.GetLength(0);
            var col = matrix.GetLength(1);
            var max = 0;
            int[,] height = new int[row, col];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (matrix[i, j] == '0')
                    {
                        height[i, j] = 0;
                    }
                    else
                    {
                        if (i == 0)
                        {
                            height[i, j] = 1;
                        }
                        else
                        {
                            height[i, j] = height[i - 1, j] + 1;
                        }
                    }
                }
            }

            for (int i = 0; i < row; i++)
            {
                var stack = new Stack<int>();
                int j = 0;

                while (j < col)
                {
                    if (stack.Count == 0 || height[i, j] >= height[i, stack.Peek()])
                    {
                        stack.Push(j++);
                    }
                    else
                    {
                        var k = stack.Pop();

                        var area = height[i, k] * (stack.Count == 0 ? j : (j - stack.Peek() - 1));

                        if (area > max)
                        {
                            max = area;
                        }
                    }
                }

                while (stack.Count > 0)
                {
                    var k = stack.Pop();

                    var area = height[i, k] * (stack.Count == 0 ? j : (j - stack.Peek() - 1));

                    if (area > max)
                    {
                        max = area;
                    }
                }
            }

            return max;
        }
    }
}
