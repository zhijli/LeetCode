using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LeetCode
{
    class P42
    {
        public int Trap(int[] height)
        {
            int result = 0;
            int leftIndex = 0;
            int rightIndex = height.Length - 1;
            int leftMaxHeight = 0;
            int rightMaxHeight = 0;
            var leftStack = new Stack<int>();
            var rightStack = new Stack<int>();

            while (leftIndex < rightIndex)
            {
                var lHeight = height[leftIndex];
                var rHeight = height[rightIndex];

                if (lHeight < rHeight)
                {
                    if (lHeight > leftMaxHeight)
                    {
                        leftMaxHeight = lHeight;
                        leftStack.Push(leftIndex);
                    }
                    leftIndex++;
                }
                else
                {
                    if (rHeight > rightMaxHeight)
                    {
                        rightMaxHeight = rHeight;
                        rightStack.Push(rightIndex);
                    }
                    rightIndex--;
                }
            }

            while (leftStack.Count > 0)
            {
                int index = leftStack.Pop();
                result += height[index] * (leftIndex - index - 1);
                for (int i = index + 1; i <= leftIndex - 1; i++)
                {
                    result -= height[i];
                }
                leftIndex = index;
            }

            while (rightStack.Count > 0)
            {
                int index = rightStack.Pop();
                result += height[index] * ( index - rightIndex - 1);
                for (int i = rightIndex + 1; i <= index - 1; i++)
                {
                    result -= height[i];
                }
                rightIndex = index;
            }

            return result;
        }
    }
}
