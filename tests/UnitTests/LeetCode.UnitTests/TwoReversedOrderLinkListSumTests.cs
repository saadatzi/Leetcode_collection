using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using static LeetCode.TwoReversedOrderLinkListSum;

namespace LeetCode.UnitTests;

public class TwoReversedOrderLinkListSumTests
{
    public class Test_TwoReversedOrderLinkListSum
    {
        [Fact]
        public void TestAddTwoNumbers_WithEmptyLists_ReturnsNull()
        {
            var result = AddTwoNumbers(null, null);

            Assert.Null(result);
        }

        [Fact]
        public void TestAddTwoNumbers_SingleDigitNumbers_ReturnsCorrectResult()
        {
            var l1 = new ListNode(2);
            var l2 = new ListNode(3);

            var result = AddTwoNumbers(l1, l2);

            Assert.NotNull(result);
            Assert.Equal(5, result.val);
            Assert.Null(result.next);
        }

        [Fact]
        public void TestAddTwoNumbers_SequencesWithCarry_ReturnsCorrectResult()
        {
            var l1 = new ListNode(9, new ListNode(8));
            var l2 = new ListNode(7, new ListNode(6));

            var result = AddTwoNumbers(l1, l2);

            Assert.NotNull(result);
            Assert.Equal(6, result.val);
            Assert.NotNull(result.next);
            Assert.Equal(5, result.next.val);
            Assert.NotNull(result.next.next);
            Assert.Equal(1, result.next.next.val);
        }

        [Fact]
        public void TestAddTwoNumbers_NotEqualLength_ReturnsCorrectResult()
        {
            var l1 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9)))))));
            var l2 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9))));

            var result = AddTwoNumbers(l1, l2);

            Assert.NotNull(result);
            Assert.Equal(8, result.val);
            Assert.NotNull(result.next);
            Assert.Equal(9, result.next.val);
            Assert.NotNull(result.next.next);
            Assert.Equal(9, result.next.next.val);
        }
    }
}
