// -----------------------------------------------------------------------
//  <copyright company="Microsoft">
//      Copyright (c) Microsoft Corporation.  All rights reserved.
//  </copyright>
// -----------------------------------------------------------------------

namespace LeetCode
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class P11_ContainerWithMostWater
    {
        public int MaxArea(int[] height)
        {
            var maxSize = 0;
            int i = 0;
            int j = height.Length - 1;

            while (i < j)
            {
                var size = (j - i) * Math.Min(height[i], height[j]);
                if (maxSize < size)
                {
                    maxSize = size;
                }

                if (height[i] < height[j])
                {
                    i++;
                }
                else
                {
                    j--;
                }
            }

            return maxSize;
        }
    }
}
