using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCode;

public class AllPossibleSubsets2
{
    public static IList<IList<int>> SubsetsWithDup(int[] nums)
    {
        Array.Sort(nums); // Sort the array to handle duplicates easily
        List<IList<int>> subsets = new List<IList<int>>();
        Backtrack(subsets, new List<int>(), nums, 0);
        return subsets;
    }

    private static  void Backtrack(List<IList<int>> subsets, List<int> current, int[] nums, int start)
    {
        // Add a copy of the current subset to the result list
        subsets.Add(new List<int>(current));

        for (int i = start; i < nums.Length; i++)
        {
            if (i > start && nums[i] == nums[i - 1]) continue; // Skip duplicates

            current.Add(nums[i]);
            Backtrack(subsets, current, nums, i + 1);
            current.RemoveAt(current.Count - 1); // Backtrack
        }
    }
}