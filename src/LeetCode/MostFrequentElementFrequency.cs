using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCode;

public class MostFrequentElementFrequency
{
    public static int MaxFrequency(int[] nums, int k) {
        int left = 0;
        int right = 1;
        Array.Sort(nums);

        // check if right index reach the end of the nums array
        while (right < nums.Length)
        {
            // check if sum of window slide with k > right bound * length of window slide
            // then increase the window slide from the right.
            // otherwise take one step the ws  to right 
            long boundSum = 0;
            for(int index = left; index <= right; index++)
            {
                boundSum += nums[index];
            }

            if (boundSum + k >= (long)(nums[right] * (right - left + 1)) )
            {
                right++;
            }
            else 
            {
                right++;
                left++;
            }

        }
        return right - left;
    }
}