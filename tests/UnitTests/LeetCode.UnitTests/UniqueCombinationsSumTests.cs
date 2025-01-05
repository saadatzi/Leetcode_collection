using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace LeetCode.UnitTests;

public class UniqueCombinationsSumTests
{
    [Fact]
    public void Example1()
    {
        var candidates = new int[] { 2, 3, 6, 7 };
        var target = 7;
        var expected = new List<IList<int>>()
        {
            new List<int> { 2, 2, 3 },
            new List<int> { 7 }
        };

        var result = UniqueCombinationsSum.CombinationSum(candidates, target);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Example2()
    {
        var candidates = new int[] { 2, 3, 5 };
        var target = 8;
        var expected = new List<IList<int>>()
        {
            new List<int> { 2, 2, 2, 2 },
            new List<int> { 2, 3, 3 },
            new List<int> { 3, 5 }
        };

        var result = UniqueCombinationsSum.CombinationSum(candidates, target);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Example3()
    {
        var candidates = new int[] { 2 };
        var target = 1;
        var expected = new List<IList<int>>();

        var result = UniqueCombinationsSum.CombinationSum(candidates, target);

        Assert.Equal(expected, result);
    }
}
