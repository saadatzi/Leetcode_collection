using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;

public class WellFormedParentheses
{
    public static IList<string> GenerateParenthesis(int n) {
        List<string> result = new ();
        backtrack(result, new StringBuilder(), 0, 0, n);

        return result;
    }

    private static void backtrack(List<string> result, StringBuilder current, int open, int close, int max)
    {
        if(current.Length == max * 2)
        {
            result.Add(current.ToString());
            return;
        }

        if(open < max)
        {
            current.Append("(");
            backtrack(result, current, open + 1, close, max);
            current.Length--;
        }

        if(close < open)
        {
            current.Append(")");
            backtrack(result, current, open, close + 1, max);
            current.Length--;
        }
    }
}