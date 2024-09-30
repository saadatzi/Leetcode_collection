using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace LeetCode.UnitTests;

public class MedianTwoSortedArraysTests
{
    [Fact]
    public void Test_Case_1()
    {
        int[] nums1 = { 1, 3 };
        int[] nums2 = { 2 };
        double expected = 2.0;
        Assert.Equal(expected, MedianTwoSortedArrays.FindMedianSortedArrays(nums1, nums2));
    }

    [Fact]
    public void Test_Case_2()
    {
        int[] nums1 = { 1, 2 };
        int[] nums2 = { 3, 4 };
        double expected = 2.5;
        Assert.Equal(expected, MedianTwoSortedArrays.FindMedianSortedArrays(nums1, nums2));
    }

    [Fact]
    public void Test_Case_3()
    {
        int[] nums1 = { };
        int[] nums2 = { 1 };
        double expected = 1.0;
        Assert.Equal(expected, MedianTwoSortedArrays.FindMedianSortedArrays(nums1, nums2));
    }

    [Fact]
    public void Test_Case_4()
    {
        int[] nums1 = { 2 };
        int[] nums2 = {};
        double expected = 2.0;
        Assert.Equal(expected, MedianTwoSortedArrays.FindMedianSortedArrays(nums1, nums2));
    }

    [Fact]
    public void Test_Case_5()
    {
        int[] nums1 = { 3 };
        int[] nums2 = {-2, -1};
        double expected = -1.0;
        Assert.Equal(expected, MedianTwoSortedArrays.FindMedianSortedArrays(nums1, nums2));
    }
}