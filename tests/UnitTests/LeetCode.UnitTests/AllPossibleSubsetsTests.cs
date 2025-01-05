using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace LeetCode.UnitTests;

public class AllPossibleSubsetsTests
{
    [Fact]
    public void TestSubsets()
    {
        // Arrange
        int[] nums = { 1, 2, 3 };
        IList<IList<int>> expected = new List<IList<int>>
        {
            new List<int>(),       // []
            new List<int> { 1 },    // [1]
            new List<int> { 2 },    // [2]
            new List<int> { 1, 2 }, // [1, 2]
            new List<int> { 3 },    // [3]
            new List<int> { 1, 3 }, // [1, 3]
            new List<int> { 2, 3 }, // [2, 3]
            new List<int> { 1, 2, 3 }// [1, 2, 3]
        };

        // Act
        IList<IList<int>> actual = AllPossibleSubsets.Subsets(nums);

        // Assert
        Assert.Equal(expected.Count, actual.Count);
        
        foreach (var expectedSubset in expected)
        {
            Assert.Contains(expectedSubset, actual);
        }
    }

    [Fact]
    public void TestEmptySet()
    {        
        // Arrange
        int[] nums = { };
        IList<IList<int>> expected = new List<IList<int>>
        {
            new List<int>() // []
        };

        // Act
        IList<IList<int>> actual = AllPossibleSubsets.Subsets(nums);

        // Assert
        Assert.Equal(expected.Count, actual.Count);
        
        foreach (var expectedSubset in expected)
        {
            Assert.Contains(expectedSubset, actual);
        }
    }

    [Fact]
    public void TestSingleElementSet()
    {
        
        // Arrange
        int[] nums = { 1 };
        IList<IList<int>> expected = new List<IList<int>>
        {
            new List<int>(),       // []
            new List<int> { 1 }    // [1]
        };

        // Act
        IList<IList<int>> actual = AllPossibleSubsets.Subsets(nums);

        // Assert
        Assert.Equal(expected.Count, actual.Count);
        
        foreach (var expectedSubset in expected)
        {
            Assert.Contains(expectedSubset, actual);
        }
    }
}
