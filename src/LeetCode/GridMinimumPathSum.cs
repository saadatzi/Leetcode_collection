using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCode;

public class GridMinimumPathSum
{
    public static int MinPathSum(int[][] grid)
    {
        if (grid == null || grid.Length == 0 || grid[0].Length == 0)
            return 0;

        int rows = grid.Length;
        int cols = grid[0].Length;

        // Create a DP table with the same dimensions as the grid
        int[,] dp = new int[rows, cols];

        // Initialize the top-left corner of the DP table
        dp[0, 0] = grid[0][0];

        // Fill in the first column of the DP table
        for (int i = 1; i < rows; i++)
        {
            dp[i, 0] = dp[i - 1, 0] + grid[i][0];
        }

        // Fill in the first row of the DP table
        for (int j = 1; j < cols; j++)
        {
            dp[0, j] = dp[0, j - 1] + grid[0][j];
        }

        // Fill in the rest of the DP table
        for (int i = 1; i < rows; i++)
        {
            for (int j = 1; j < cols; j++)
            {
                dp[i, j] = Math.Min(dp[i - 1, j], dp[i, j - 1]) + grid[i][j];
            }
        }

        // The bottom-right corner of the DP table contains the minimum path sum
        return dp[rows - 1, cols - 1];
    }
}