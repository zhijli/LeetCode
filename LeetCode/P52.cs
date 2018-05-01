using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class P52
    {
        public int TotalNQueens(int n)
        {
            var count = 0;
            char[,] result = new char[n, n];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    result[i, j] = '.';

            TotalNQueens(n, 0, result, ref count);
            return count;
        }

        private void TotalNQueens(int n, int row, char[,] result, ref int count)
        {
            if (row == n)
            {
                count++;
                return;
            }

            for (int col = 0; col < n; col++)
            {
                if (IsValid(n, row, col, result))
                {
                    result[row, col] = 'Q';
                    TotalNQueens(n, row + 1, result, ref count);
                    result[row, col] = '.';
                }
            }
        }

        private bool IsValid(int n, int row, int col, char[,] result)
        {
            for (int i = 0; i < row; i++) if (result[i, col] == 'Q') return false;
            for (int i = 0; row >= i && col >= i; i++) if (result[row - i, col - i] == 'Q') return false;
            for (int i = 0; row >= i && col + i < n; i++) if (result[row - i, col + i] == 'Q') return false;

            return true;
        }
    }
}
