using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCode;

public class TwoSumArrayTarget
{
    public static int[] TwoSum(int[] numbers, int target)
    {
        int left = 0;
        int right = numbers.Length - 1;

        while (left < right)
        {
            int currentSum = numbers[left] + numbers[right];

            if (currentSum == target)
            {
                // Return 1-based indices
                return new int[] { left + 1, right + 1 };
            }
            else if (currentSum < target)
            {
                left++;
            }
            else
            {
                right--;
            }
        }

        return [-1, -1];
    }
}