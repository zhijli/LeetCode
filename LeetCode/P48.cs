using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class P48
    {
        public void Rotate(int[,] matrix)
        {
            if (matrix == null || matrix.Length == 0) return;

            var n = matrix.GetLength(0);
            for (int i = 0; i < n / 2; i++)
            {
                for (int j = i; j < n - i - 1; j++)
                {
                    Rotate(matrix, n, i, j);
                }
            }
        }

        private void Rotate(int[,] matrix, int x, int i, int j)
        {
            int n = x - 1;
            var temp = matrix[i, j];
            matrix[i, j] = matrix[n - j, i];
            matrix[n - j, i] = matrix[n - i, n - j];
            matrix[n - i, n - j] = matrix[j, n - i];
            matrix[j, n - i] = temp;
        }
    }
}
