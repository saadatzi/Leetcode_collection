using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCode;

public class LongestDistinctiveSubstring
{
    public static int? LengthOfLongestSubstring(string? s) 
    {
        // Check if string s is empty or null
        if (string.IsNullOrEmpty(s))
        {
            return 0;
        }
        var charIndexMap = new Dictionary<char, int> ();

        int maxLength = 0;

        int start = 0;

        for (int end = 0; end < s.Length; end++)
        {
            if(charIndexMap.TryGetValue(s[end], out int value))
            {
                maxLength = Math.Max(maxLength, end - start);
                start = Math.Max(start, charIndexMap[s[end]] + 1);
            }
            charIndexMap[s[end]] = end;
        }
        maxLength = Math.Max(maxLength, s.Length - start);
        return maxLength;
    }
}