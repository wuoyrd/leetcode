using System.Numerics;

namespace LeetCode.Problems
{
    public static class Problem0002
    {
        public static ListNode? AddTwoNumbers(ListNode? l1, ListNode? l2)
            => ToListNode(ToBigInteger(l1) + ToBigInteger(l2));

        public static ListNode? ToListNode(BigInteger value)
            => new((int)(value % 10), value / 10 == 0 ? null : ToListNode(value / 10));

        public static BigInteger ToBigInteger(ListNode? head)
            => ToBigInteger(head, 1);

        private static BigInteger ToBigInteger(ListNode? head, BigInteger factor)
            => head is null ? 0 : (head.val * factor) + ToBigInteger(head.next, factor * 10);


        public record ListNode(int val = 0, ListNode? next = null);
    }
}
