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

    class P74
    {
        public bool SearchMatrix(int[,] matrix, int target)
        {
            int row = matrix.GetLength(0);
            int col = matrix.GetLength(1);
            int up = 0;
            int bottom = row - 1;
            int mid;

            while (up < bottom)
            {
                mid = (up + bottom) / 2;
                if (matrix[mid, col - 1] > target)
                {
                    bottom = mid;
                }
                else if (matrix[mid, col - 1] < target)
                {
                    up = mid + 1;
                }
                else
                {
                    return true;
                }
            }

            if (up > bottom)
            {
                return false;
            }

            int left = 0;
            int right = col - 1;
            while (left <= right)
            {
                mid = (left + right) / 2;

                if (matrix[up, mid] > target)
                {
                    right = mid - 1;
                }
                else if (matrix[up, mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }
    }
}
