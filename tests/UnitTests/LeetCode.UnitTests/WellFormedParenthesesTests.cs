using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace LeetCode.UnitTests;

public class GenerateParenthesisTests
{
    [Fact]
    public void TestGenerateParenthesisWithN1()
    {
        var result = WellFormedParentheses.GenerateParenthesis(1);
        
        // Since the order of elements in a list is not guaranteed, we need to check each item individually.
        Assert.Contains("()", result);
        Assert.Equal(1, result.Count); // Ensure only one combination is returned for n=1
    }

    [Fact]
    public void TestGenerateParenthesisWithN3()
    {
        var result = WellFormedParentheses.GenerateParenthesis(3);
        
        // Since the order of elements in a list is not guaranteed, we need to check each item individually.
        Assert.Contains("((()))", result);
        Assert.Contains("(()())", result);
        Assert.Contains("(())()", result);
        Assert.Contains("()(())", result);
        Assert.Contains("()()()", result);
        Assert.Equal(5, result.Count); // Ensure all combinations are returned for n=3
    }

    [Fact]
    public void TestGenerateParenthesisWithN4()
    {
        var result = WellFormedParentheses.GenerateParenthesis(4);
        
        // Since the order of elements in a list is not guaranteed, we need to check each item individually.
        Assert.Contains("(((())))", result);
        Assert.Contains("((()()))", result);
        Assert.Contains("(()(()))", result);
        Assert.Contains("(()())()", result);
        Assert.Contains("(())(())", result);
        Assert.Contains("(())()()", result);
        Assert.Contains("()((()))", result);
        Assert.Contains("()(()())", result);
        Assert.Contains("()(())()", result);
        Assert.Contains("()()()()", result);
        Assert.Equal(14, result.Count); // Ensure all combinations are returned for n=4
    }
}
