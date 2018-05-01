using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class P63
    {
        public int UniquePathsWithObstacles(int[,] obstacleGrid)
        {
            int row = obstacleGrid.GetLength(0);
            int col = obstacleGrid.GetLength(1);
            int[,] dp = new int[row, col];

            if (obstacleGrid[row - 1, col - 1] == 0)
            {
                dp[row - 1, col - 1] = 1;
            }

            for (int i = row - 1; i >= 0; i--)
            {
                for (int j = col - 1; j >= 0; j--)
                {
                    if (obstacleGrid[i, j] == 0)
                    {
                        if (i < row - 1 && obstacleGrid[i + 1, j] == 0)
                        {
                            dp[i, j] += dp[i + 1, j];
                        }
                        if (j < col - 1 && obstacleGrid[i, j + 1] == 0)
                        {
                            dp[i, j] += dp[i, j + 1];
                        }
                    }
                }
            }

            return dp[0, 0];
        }
    }
}
