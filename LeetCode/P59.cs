using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class P59
    {
        public int[,] GenerateMatrix(int n)
        {
            int[,] result = new int[n, n];

            GenerateMatrix(0, 0, n - 1, n - 1, 1, result);

            return result;
        }

        private void GenerateMatrix(int sRow, int sCol, int eRow, int eCol, int val, int[,] result)
        {
            if (sRow > eRow || sCol > eCol) return;
            if (sRow == eRow)
            {
                result[sRow, sCol] = val;
                return;
            }

            for (int i = sCol; i < eCol; i++) result[sRow, i] = val++;
            for (int i = sRow; i < eRow; i++) result[i, eCol] = val++;
            for (int i = eCol; i > sCol; i--) result[eRow, i] = val++;
            for (int i = eRow; i > sRow; i--) result[i, sCol] = val++;

            GenerateMatrix(sRow + 1, sCol + 1, eRow - 1, eCol - 1, val, result);
        }
    }
}
