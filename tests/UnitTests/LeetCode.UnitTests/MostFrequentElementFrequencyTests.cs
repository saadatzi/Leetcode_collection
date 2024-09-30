using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace LeetCode.UnitTests;

public class MostFrequentElementFrequencyTests
{
    [Fact]
    public void TestMaxFrequency_Example1()
    {
        int result = MostFrequentElementFrequency.MaxFrequency(new int[] { 1, 2, 4 }, 5);
        Assert.Equal(3, result);
    }

    [Fact]
    public void TestMaxFrequency_Example2()
    {
        int result = MostFrequentElementFrequency.MaxFrequency(new int[] { 1, 4, 8, 13 }, 5);
        Assert.Equal(2, result);
    }

    [Fact]
    public void TestMaxFrequency_Example3()
    {
        int result = MostFrequentElementFrequency.MaxFrequency(new int[] { 3, 9, 6 }, 2);
        Assert.Equal(1, result);
    }

    [Fact]
    public void TestMaxFrequency_SingleElement()
    {
        int result = MostFrequentElementFrequency.MaxFrequency(new int[] { 1 }, 5);
        Assert.Equal(1, result);
    }

    [Fact]
    public void TestMaxFrequency_AllSameElements()
    {
        int result = MostFrequentElementFrequency.MaxFrequency(new int[] { 3, 3, 3, 3 }, 10);
        Assert.Equal(4, result);
    }

    [Fact]
    public void TestMaxFrequency_LargeArray()
    {
        int k = 3056;
        int result = MostFrequentElementFrequency.MaxFrequency([9930,9923,9983,9997,9934,9952,9945,9914,9985,9982,9970,9932,9985,9902,9975,9990,9922,9990,9994,9937,9996,9964,9943,9963,9911,9925,9935,9945,9933,9916,9930,9938,10000,9916,9911,9959,9957,9907,9913,9916,9993,9930,9975,9924,9988,9923,9910,9925,9977,9981,9927,9930,9927,9925,9923,9904,9928,9928,9986,9903,9985,9954,9938,9911,9952,9974,9926,9920,9972,9983,9973,9917,9995,9973,9977,9947,9936,9975,9954,9932,9964,9972,9935,9946,9966], k);
        Assert.Equal(73, result); // This is an approximation based on the problem constraints
    }

    [Fact]
    public void TestMaxFrequency_WhenAlmostAllElementLackAFewButLargeArray_()
    {
        int[] array = new int[100000];
        array[0] = 100000;
        for (long i = 1; i < 100000; i++)
        {
            array[i] = 99999;
        }
        int k = 100000;
        int result = MostFrequentElementFrequency.MaxFrequency(array, k);
        Assert.Equal(100000, result); // This is an approximation based on the problem constraints
    }
}
