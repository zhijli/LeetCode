using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class P51
    {
        public IList<IList<string>> SolveNQueens(int n)
        {
            var results = new List<IList<string>>();
            char[,] result = new char[n, n];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    result[i, j] = '.';

            SolveNQueens(n, 0, results, result);

            return results;
        }

        private void SolveNQueens(int n, int row, List<IList<string>> results, char[,] result)
        {
            if (row == n)
            {
                results.Add(BuildResult(result));
                return;
            }

            for (int col = 0; col < n; col++)
            {
                if (IsValid(result, n, row, col))
                {
                    result[row, col] = 'Q';
                    SolveNQueens(n, row + 1, results, result);
                    result[row, col] = '.';
                }
            }
        }

        private IList<string> BuildResult(char[,] charArray)
        {
            var result = new List<string>();
            for (int i = 0; i < charArray.GetLength(0); i++)
            {
                var sb = new StringBuilder();
                for (int j = 0; j < charArray.GetLength(0); j++)
                {
                    sb.Append(charArray[i, j]);
                }
                result.Add(sb.ToString());
            }
            return result;
        }

        private bool IsValid(char[,] result, int n, int row, int col)
        {
            for (int i = 0; i < row; i++)
            {
                if (result[i, col] == 'Q') return false;
            }
            for (int i = 1; row - i >= 0 && col - i >= 0; i++)
            {
                if (result[row - i, col - i] == 'Q') return false;
            }
            for (int i = 1; row - i >= 0 && col + i <= n - 1; i++)
            {
                if (result[row - i, col + i] == 'Q') return false;
            }
            return true;
        }
    }
}
