using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCode;

public class AllPossibleSubsets
{
    public static IList<IList<int>> Subsets(int[] nums)
    {
        List<IList<int>> result = new List<IList<int>>();

        shapeSubsets(result, new List<int>(), 0, nums);

        return result;
    }

    private static void shapeSubsets(List<IList<int>> result, IList<int> subset, int start, int[] nums)
    {
        result.Add(new List<int>(subset));

        for (int i = start; i < nums.Length; i++)
        {
            subset.Add(nums[i]);
            shapeSubsets(result, subset, i + 1, nums);
            subset.Remove(nums[i]);
        }
    }
}