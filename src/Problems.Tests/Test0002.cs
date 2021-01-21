using Shouldly;
using Xunit;

namespace LeetCode.Problems
{
    using static Problem0002;

    public class Test0002
    {
        [Theory]
        [InlineData(342, 465, 807)]
        [InlineData(0, 0, 0)]
        [InlineData(9999999, 9999, 10009998)]
        public void Test(long input1, long input2, long expected)
        {
            ListNode output = AddTwoNumbers(ToListNode(input1), ToListNode(input2));

            ToBigInteger(output).ShouldBe(expected);
            output.ShouldBe(ToListNode(expected));
        }
    }
}
