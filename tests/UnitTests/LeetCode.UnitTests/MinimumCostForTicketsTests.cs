using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace LeetCode.UnitTests;

public class MinimumCostForTicketsTests
{
    [Fact]
    public void Example1()
    {
        int[] days = { 1, 4, 6, 7, 8, 20 };
        int[] costs = { 2, 7, 15 };
        var expected = 11;

        var result = MinimumCostForTickets.MincostTickets(days, costs);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Example2()
    {
        int[] days = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 30, 31 };
        int[] costs = { 2, 7, 15 };
        var expected = 17;

        var result = MinimumCostForTickets.MincostTickets(days, costs);

        Assert.Equal(expected, result);
    }
}
