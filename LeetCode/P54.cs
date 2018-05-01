using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class P54
    {
        public IList<int> SpiralOrder(int[,] matrix)
        {
            var result = new List<int>();
            SpiralOrder(matrix, 0, 0, matrix.GetLength(0) - 1, matrix.GetLength(1) - 1, result);
            return result;
        }

        private void SpiralOrder(int[,] matrix, int sRow, int sCol, int eRow, int eCol, List<int> result)
        {
            //Be careful for the edge case
            if (sRow > eRow || sCol > eCol) return;
            if (sRow == eRow && sCol == eCol) { result.Add(matrix[sRow, eCol]); }
            else if (sRow == eRow) { for (int i = sCol; i <= eCol; i++) result.Add(matrix[sRow, i]); }
            else if (sCol == eCol) { for (int i = sRow; i <= eRow; i++) result.Add(matrix[i, sCol]); }
            else
            {
                for (int i = sCol; i < eCol; i++) result.Add(matrix[sRow, i]);
                for (int i = sRow; i < eRow; i++) result.Add(matrix[i, eCol]);
                for (int i = eCol; i > sCol && sRow != eRow; i--) result.Add(matrix[eRow, i]);
                for (int i = eRow; i > sRow && sCol != eCol; i--) result.Add(matrix[i, sCol]);
                SpiralOrder(matrix, sRow + 1, sCol + 1, eRow - 1, eCol - 1, result);
            }
        }
    }
}
