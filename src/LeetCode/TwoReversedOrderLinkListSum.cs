using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCode;

public class TwoReversedOrderLinkListSum
{
    public class ListNode(int value = 0, ListNode? next = null)
    {
        public int val = value;

        public ListNode? next = next;
    }

    public static ListNode? AddTwoNumbers(ListNode? l1, ListNode? l2)
    {
        ListNode dumyHead = new ();
        
        ListNode result = dumyHead;

        int carry = 0;

        while(l1 != null || l2 != null || carry > 0)
        {
            int l1_value = 0;
            int l2_value = 0;

            if (l1 != null)
            {
                l1_value = l1.val;
                l1 = l1.next;
            }

            if (l2 != null)
            {
                l2_value = l2.val;
                l2 = l2.next;
            }

            int sum = l1_value + l2_value + carry;
            carry = sum / 10;

            result.next = new ListNode(sum % 10);

            result = result.next;
        }

        return dumyHead.next;
    }
}
