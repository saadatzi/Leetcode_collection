using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace LeetCode.UnitTests;

public class AllPossibleSubsets2Tests
{
    [Fact]
    public void Test_Case_1()
    {
        int[] nums = { 1, 2, 2 };
        List<List<int>> expected = new List<List<int>>
        {
            new List<int>(){},
            new List<int>(){1},
            new List<int>(){1, 2},
            new List<int>(){1, 2, 2},
            new List<int>(){2},
            new List<int>(){2, 2}
        };
        var result = AllPossibleSubsets2.SubsetsWithDup(nums);
        Assert.Equal(expected.Count, result.Count);

        foreach (var subset in expected)
        {
            bool found = false;
            foreach (var resSubset in result)
            {
                if (subset.SequenceEqual(resSubset))
                {
                    found = true;
                    break;
                }
            }

            Assert.True(found, $"Expected subset {string.Join(", ", subset)} not found");
        }
    }

    [Fact]
    public void Test_Case_2()
    {
        int[] nums = { 0 };
        List<List<int>> expected = new List<List<int>>
        {
            new List<int>(){},
            new List<int>(){0}
        };

        var result = AllPossibleSubsets2.SubsetsWithDup(nums);
        Assert.Equal(expected.Count, result.Count);

        foreach (var subset in expected)
        {
            bool found = false;
            foreach (var resSubset in result)
            {
                if (subset.SequenceEqual(resSubset))
                {
                    found = true;
                    break;
                }
            }

            Assert.True(found, $"Expected subset {string.Join(", ", subset)} not found");
        }
    }
}
