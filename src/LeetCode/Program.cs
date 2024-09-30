// Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.


// An input string is valid if:

// Open brackets must be closed by the same type of brackets.
// Open brackets must be closed in the correct order.
// Every close bracket has a corresponding open bracket of the same type.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using LeetCode;

// using LeetCode.ValidParantheses;
using static LeetCode.TwoReversedOrderLinkListSum;

internal class Program
{
    private static void Main(string[] args)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        // =================== BracketValidator ===================
        // Console.WriteLine(BracketValidator.IsValid("()[]{}"));  // Output: True
        // Console.WriteLine(BracketValidator.IsValid("(]"));  // Output: True
        // Console.WriteLine(BracketValidator.IsValid("([])"));  // Output: True
        // Console.WriteLine(BracketValidator.IsValid("()"));  // Output: True

        // =================== TwoReversedOrderLinkListSum ===================
        // Example 1
        // ListNode l1 = new(2, new ListNode(4, new ListNode(3)));
        // ListNode l2 = new(5, new ListNode(6, new ListNode(4)));
        // ListNode? result = AddTwoNumbers(l1, l2);

        // // Print the result
        // while (result != null)
        // {
        //     Console.Write(result.val + " ");
        //     result = result.next;
        // }
        // Console.WriteLine(); // Output: 7 0 8

        // // Example 2
        // l1 = new ListNode(0);
        // l2 = new ListNode(0);
        // result = AddTwoNumbers(l1, l2);

        // // Print the result
        // while (result != null)
        // {
        //     Console.Write(result.val + " ");
        //     result = result.next;
        // }
        // Console.WriteLine(); // Output: 0

        // // Example 3
        // l1 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9)))))));
        // l2 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9))));
        // result = AddTwoNumbers(l1, l2);

        // // Print the result
        // while (result != null)
        // {
        //     Console.Write(result.val + " ");
        //     result = result.next;
        // }
        // Console.WriteLine(); // Output: 8 9 9 9 0 0 0 1


        // ====================         
        // Example 1
        int n1 = 3;
        var result1 = WellFormedParentheses.GenerateParenthesis(n1);
        Console.WriteLine("Example 1 Output: [" + string.Join(", ", result1) + "]");
        
        // Example 2
        int n2 = 1;
        var result2 = WellFormedParentheses.GenerateParenthesis(n2);
        Console.WriteLine("Example 2 Output: [" + string.Join(", ", result2) + "]");

        stopwatch.Stop();

        long memoryBefore = GC.GetTotalMemory(false);
        // Simulate some operations that might allocate memory
        var largeObject = new byte[1024 * 1024]; // Allocate 1MB of memory
        long memoryAfter = GC.GetTotalMemory(true);

        Console.WriteLine("Runtime: " + stopwatch.ElapsedMilliseconds + " ms");
        Console.WriteLine("Memory Allocated During Execution: " + (memoryAfter - memoryBefore) / 1024 + " Kbytes");
    }
}