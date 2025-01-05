using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace LeetCode.UnitTests;

public class GridMinimumPathSumTests
{
    [Fact]
    public void Example1()
    {
        int[][] grid = [ [ 1, 3, 1 ], [ 1, 5, 1 ], [ 4, 2, 1 ] ];
        var expected = 7;

        var result = GridMinimumPathSum.MinPathSum(grid);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Example2()
    {
        int[][] grid = [ [ 1, 2, 3 ], [ 4, 5, 6 ] ];
        var expected = 12;

        var result = GridMinimumPathSum.MinPathSum(grid);

        Assert.Equal(expected, result);
    }
}
