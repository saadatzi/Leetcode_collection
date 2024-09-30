using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace LeetCode.UnitTests;

public class TwoSumArrayTargetTests
{
    [Fact]
    public void Test_Case_1()
    {
        int[] numbers = { 2, 7, 11, 15 };
        int target = 9;
        int[] expected = { 1, 2 };
        Assert.Equal(expected, TwoSumArrayTarget.TwoSum(numbers, target));
    }

    [Fact]
    public void Test_Case_2()
    {
        int[] numbers = { 2, 3, 4 };
        int target = 6;
        int[] expected = { 1, 3 };
        Assert.Equal(expected, TwoSumArrayTarget.TwoSum(numbers, target));
    }

    [Fact]
    public void Test_Case_3()
    {
        int[] numbers = { -1, 0 };
        int target = -1;
        int[] expected = { 1, 2 };
        Assert.Equal(expected, TwoSumArrayTarget.TwoSum(numbers, target));
    }
}
