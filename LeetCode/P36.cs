using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class P36
    {
        public bool IsValidSudoku(char[,] board)
        {
            bool[] checker;

            for (int row = 0; row < 9; row++)
            {
                checker = new bool[10];
                for (int col = 0; col < 9; col++)
                {
                    if (board[row, col] != '.')
                    {
                        int val = board[row, col] - '0';
                        if (checker[val] == true)
                        {
                            return false;
                        }
                        else
                        {
                            checker[val] = true;
                        }
                    }
                }
            }

            for (int col = 0; col < 9; col++)
            {
                checker = new bool[10];
                for (int row = 0; row < 9; row++)
                {
                    if (board[row, col] != '.')
                    {
                        int val = board[row, col] - '0';
                        if (checker[val] == true)
                        {
                            return false;
                        }
                        else
                        {
                            checker[val] = true;
                        }
                    }
                }
            }

            for (int i = 0; i < 3; i++)
            {
                int centerRow = i * 3 + 1;

                for (int j = 0; j < 3; j++)
                {
                    int centerCol = j * 3 + 1;

                    checker = new bool[10];
                    for (int offsetRow = -1; offsetRow <= 1; offsetRow++)
                    {
                        for (int offsetCol = -1; offsetCol <= 1; offsetCol++)
                        {
                            if (board[centerRow + offsetRow, centerCol + offsetCol] != '.')
                            {
                                int val = board[centerRow + offsetRow, centerCol + offsetCol] - '0';
                                if (checker[val] == true)
                                {
                                    return false;
                                }
                                else
                                {
                                    checker[val] = true;
                                }
                            }
                        }
                    }
                }
            }

            return true;
        }
    }
}
