using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class P79
    {
        public bool Exist(char[,] board, string word)
        {
            if (string.IsNullOrEmpty(word)) return false;

            int row = board.GetLength(0);
            int col = board.GetLength(1);
            bool[,] t = new bool[row, col];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (word[0] == board[i, j])
                    {
                        t[i, j] = true;
                        if (Exist(board, row, col, i, j, word, 1, t))
                        {
                            return true;
                        }
                        t[i, j] = false;
                    }
                }
            }

            return false;
        }

        private bool Exist(char[,] board, int row, int col, int i, int j, string word, int index, bool[,] t)
        {
            if (index == word.Length) return true;

            if (i - 1 >= 0 && board[i - 1, j] == word[index] && t[i - 1, j] == false)
            {
                t[i - 1, j] = true;
                if (Exist(board, row, col, i - 1, j, word, index + 1, t))
                {
                    return true;
                }

                t[i - 1, j] = false;
            }

            if (i + 1 < row && board[i + 1, j] == word[index] && t[i + 1, j] == false)
            {
                t[i + 1, j] = true;
                if (Exist(board, row, col, i + 1, j, word, index + 1, t))
                {
                    return true;
                }

                t[i + 1, j] = false;
            }

            if (j - 1 >= 0 && board[i, j - 1] == word[index] && t[i, j - 1] == false)
            {
                t[i, j - 1] = true;
                if (Exist(board, row, col, i, j - 1, word, index + 1, t))
                {
                    return true;
                }

                t[i, j - 1] = false;
            }

            if (j + 1 < col && board[i, j + 1] == word[index] && t[i, j + 1] == false)
            {
                t[i, j + 1] = true;
                if (Exist(board, row, col, i, j + 1, word, index + 1, t))
                {
                    return true;
                }

                t[i, j + 1] = false;
            }
            return false;
        }
    }
}
