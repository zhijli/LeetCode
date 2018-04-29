using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class P37
    {
        public void SolveSudoku(char[,] board)
        {
            SolveSudoku(board, 0, 0);
        }

        private bool SolveSudoku(char[,] board, int row, int col)
        {
            if (col == 9) return SolveSudoku(board, row + 1, 0);
            if (row == 9) return true;

            if (board[row, col] == '.')
            {
                var checker = new bool[10];
                for (int i = 0; i < 9; i++)
                {
                    var block = board[row, i];
                    if (block != '.')
                    {
                        checker[block - '0'] = true;
                    }

                    block = board[i, col];
                    if (block != '.')
                    {
                        checker[block - '0'] = true;
                    }
                }

                int centerRow = (row / 3) * 3 + 1;
                int centerCol = (col / 3) * 3 + 1;
                for (int offsetRow = -1; offsetRow <= 1; offsetRow++)
                {
                    for (int offsetCol = -1; offsetCol <= 1; offsetCol++)
                    {
                        var block = board[centerRow + offsetRow, centerCol + offsetCol];
                        if (block != '.')
                        {
                            checker[block - '0'] = true;
                        }
                    }
                }

                for (int val = 1; val <= 9; val++)
                {
                    if (checker[val] != true)
                    {
                        board[row, col] = (char)(val + '0');
                        if (SolveSudoku(board, row, col + 1))
                        {
                            return true;
                        }
                    }
                }
                board[row, col] = '.';
                return false;
            }
            else
            {
                return SolveSudoku(board, row, col + 1);
            }
        }
    }
}
