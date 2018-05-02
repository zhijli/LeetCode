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

    class P73
    {
        public void SetZeroes(int[,] matrix)
        {
            var row = matrix.GetLength(0);
            var col = matrix.GetLength(1);

            bool[] rows = new bool[row];
            bool[] cols = new bool[col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        rows[i] = true;
                        cols[j] = true;
                    }
                }
            }

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (rows[i]|| cols[j]) matrix[i, j] = 0;
                }
            }
        }
    }
}
