using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace LeetCode.UnitTests;

public class MinimumWindowSubstringTests
{
    [Fact]
    public void TestMinWindow_Example1()
    {
        string result = MinimumWindowSubstring.MinWindow("ADOBECODEBANC", "ABC");
        Assert.Equal("BANC", result);
    }

    [Fact]
    public void TestMinWindow_Example2()
    {
        string result = MinimumWindowSubstring.MinWindow("a", "a");
        Assert.Equal("a", result);
    }

    [Fact]
    public void TestMinWindow_Example3()
    {
        string result = MinimumWindowSubstring.MinWindow("a", "aa");
        Assert.Equal("", result);
    }

    [Fact]
    public void TestMinWindow_EmptyStringS()
    {
        string result = MinimumWindowSubstring.MinWindow("", "a");
        Assert.Equal("", result);
    }

    [Fact]
    public void TestMinWindow_EmptyStringT()
    {
        string result = MinimumWindowSubstring.MinWindow("abc", "");
        Assert.Equal("", result);
    }

    [Fact]
    public void TestMinWindow_ShorterThanT()
    {
        string result = MinimumWindowSubstring.MinWindow("ab", "abcd");
        Assert.Equal("", result);
    }

    [Fact]
    public void TestMinWindow_OverlapCharacters()
    {
        string result = MinimumWindowSubstring.MinWindow("aa", "aa");
        Assert.Equal("aa", result);
    }
}
