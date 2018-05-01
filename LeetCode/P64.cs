using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class P64
    {
        public int MinPathSum(int[,] grid)
        {
            int row = grid.GetLength(0);
            int col = grid.GetLength(1);

            int?[,] dp = new int?[row, col];

            dp[row - 1, col - 1] = grid[row - 1, col - 1];

            for (int i = row - 1; i >= 0; i--)
            {
                for (int j = col - 1; j >= 0; j--)
                {
                    if (i < row - 1)
                    {
                        if (dp[i, j] == null)
                        {
                            dp[i, j] = grid[i, j] + dp[i + 1, j];
                        }
                        else
                        {
                            dp[i, j] = Math.Min(grid[i, j] + dp[i + 1, j].Value, dp[i, j].Value);
                        }
                    }

                    if (j < col - 1)
                    {
                        if (dp[i, j] == null)
                        {
                            dp[i, j] = grid[i, j] + dp[i, j + 1];
                        }
                        else
                        {
                            dp[i, j] = Math.Min(grid[i, j] + dp[i, j + 1].Value, dp[i, j].Value);
                        }
                    }
                }
            }

            return dp[0, 0].Value;
        }
    }
}
