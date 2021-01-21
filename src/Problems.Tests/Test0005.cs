using Shouldly;
using Xunit;

namespace LeetCode.Problems
{
    using static Problem0005;

    public class Test0005
    {
        [Theory]
        [InlineData(123, 321)]
        [InlineData(-123, -321)]
        [InlineData(120, 21)]
        [InlineData(0, 0)]
        [InlineData(1534236469, 0)]
        public void Test_v1(int input, int expected)
        {
            int actual = Reverse_v1(input);
            actual.ShouldBe(expected);
        }

        [Theory]
        [InlineData(123, 321)]
        [InlineData(-123, -321)]
        [InlineData(120, 21)]
        [InlineData(0, 0)]
        [InlineData(1534236469, 0)]
        public void Test_v2(int input, int expected)
        {
            int actual = Reverse_v2(input);
            actual.ShouldBe(expected);
        }
    }
}
