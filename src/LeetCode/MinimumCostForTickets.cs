using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCode;

public class MinimumCostForTickets
{
    public static int MincostTickets(int[] days, int[] costs)
    {
        if (days == null || days.Length == 0) return 0;

        int n = days.Length;
        int lastDay = days[n - 1];
        int[] dp = new int[lastDay + 1];

        HashSet<int> travelDays = new HashSet<int>();
        foreach (var day in days)
        {
            travelDays.Add(day);
        }

        for (int i = 1; i <= lastDay; i++)
        {
            if (travelDays.Contains(i))
            {
                dp[i] = Math.Min(dp[Math.Max(0, i - 1)] + costs[0], 
                                Math.Min(dp[Math.Max(0, i - 7)] + costs[1],
                                         dp[Math.Max(0, i - 30)] + costs[2]));
            }
            else
            {
                dp[i] = dp[i - 1];
            }
        }

        return dp[lastDay];
    }
}