using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCode;

public class UniqueCombinationsSum
{
    public static IList<IList<int>> CombinationSum(int[] candidates, int target)
    {
            IList<IList<int>> result = new List<IList<int>>();
            Array.Sort(candidates);
            backtrack(result, new List<int>(), 0, target, candidates);

            return result;
    }

    private static void backtrack(IList<IList<int>> result, List<int> sample, int start, int target, int[] candidates)
    {
        if (sample.Sum() == target)
        {
            result.Add(new List<int>(sample));
            return;
        }
        else if (sample.Sum() > target)
        {
            return;
        }

        for (int i = start; i < candidates.Length; i++ )
        {
            sample.Add(candidates[i]);

            // if (i > start && candidates[i] == candidates[i - 1]) continue; // Skip duplicates

            backtrack(result, sample, i, target, candidates);
            sample.RemoveAt(sample.Count - 1);
        }
    }
}
