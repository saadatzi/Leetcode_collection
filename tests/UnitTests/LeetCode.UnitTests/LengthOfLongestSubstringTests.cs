using BenchmarkDotNet.Attributes;

namespace LeetCode.UnitTests;

public class LengthOfLongestSubstringTests
{
    [Fact]
    public void LengthOfLongestSubstring_WhenInputIsMirror_ReturnsLengthOfInput()
    {
        var input = "abba";
        int expected = 2;
        var result = LongestDistinctiveSubstring.LengthOfLongestSubstring(input);
        
        Assert.Equal(expected, result);
    }

    [Fact]
    public void LengthOfLongestSubstring_WhenInputIsUniqueCharacters_ReturnsLengthOfInput()
    {
        var input = "abcdefg";
        int expected = 7;
        var result = LongestDistinctiveSubstring.LengthOfLongestSubstring(input);
        
        Assert.Equal(expected, result);
    }

    [Fact]
    public void LengthOfLongestSubstring_WhenInputContainsRepeatingCharacters_ReturnsCorrectLength()
    {
        var input = "abcabcbb";
        int expected = 3;
        var result = LongestDistinctiveSubstring.LengthOfLongestSubstring(input);
        
        Assert.Equal(expected, result);
    }

    [Fact]
    public void LengthOfLongestSubstring_WhenInputIsEmpty_ReturnsZero()
    {
        var input = "";
        int expected = 0;
        var result = LongestDistinctiveSubstring.LengthOfLongestSubstring(input);
        
        Assert.Equal(expected, result);
    }

    [Fact]
    public void LengthOfLongestSubstring_WhenInputIsNull_ReturnsZero()
    {
        string? input = null;
        int expected = 0;
        var result = LongestDistinctiveSubstring.LengthOfLongestSubstring(input);
        
        Assert.Equal(expected, result);
    }
}