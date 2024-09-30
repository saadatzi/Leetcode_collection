using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCode;

public class MinimumWindowSubstring
{
    public static string MinWindow(string s, string t)
    {
        if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t))
            return "";

        int [] targetCount = new int[128];
        foreach (char c in t)
        {
            targetCount[c]++;
        }

        int required = targetCount.Count(x => x>0);
        int formed = 0;

        int [] windowCounts = new int[128];

        int left = 0, right = 0;
        int ansLength = int.MaxValue;
        int ansLeft = -1, ansRight = -1;

        while (right < s.Length)
        {
            char c = s[right];
            windowCounts[c]++;

            if (targetCount[c] == windowCounts[c])
                formed++;

            while (left <= right && required == formed)
            {
                char d = s[left];

                // Save the smallest window until now.
                if (right - left + 1 < ansLength)
                {
                    ansLength = right - left + 1;
                    ansLeft = left;
                    ansRight = right;
                }

                windowCounts[d]--;
                if (windowCounts[d] < targetCount[d])
                    formed--;

                left++;
            }

            right++;
        }

        return ansLength == int.MaxValue ? "" : s.Substring(ansLeft, ansLength);
    }
}
