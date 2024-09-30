using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCode;

public class BracketValidator
{
    public static bool IsValid(string s)
    {
        // Dictionary to store the pairs of brackets
        Dictionary<char, char> bracketPairs = new Dictionary<char, char>
        {
            { ')', '(' },
            { '}', '{' },
            { ']', '[' }
        };

        // Stack to keep track of opening brackets
        Stack<char> stack = new Stack<char>();

        foreach (char c in s)
        {
            if (bracketPairs.ContainsValue(c))
            {
                // If it's an opening bracket, push it onto the stack
                stack.Push(c);
            }
            else if (bracketPairs.ContainsKey(c))
            {
                // If it's a closing bracket, check if the stack is empty or the top of the stack doesn't match the corresponding opening bracket
                if (!stack.Any() || stack.Pop() != bracketPairs[c])
                {
                    return false;
                }
            }
        }

        // Finally, check if the stack is empty
        return !stack.Any();
    }
}