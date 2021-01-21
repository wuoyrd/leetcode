using Shouldly;
using Xunit;

namespace LeetCode.Problems
{
    using static Problem0003;

    public class Test0003
    {
        [Theory]
        [InlineData("abcabcbb", 3)]
        [InlineData("bbbbb", 1)]
        [InlineData("pwwkew", 3)]
        [InlineData("", 0)]
        public void Test_v1(string input, int expected)
        {
            int actual = LengthOfLongestSubstring_v1(input);
            actual.ShouldBe(expected);
        }

        [Theory]
        [InlineData("abcabcbb", 3)]
        [InlineData("bbbbb", 1)]
        [InlineData("pwwkew", 3)]
        [InlineData("", 0)]
        public void Test_v2(string input, int expected)
        {
            int actual = LengthOfLongestSubstring_v2(input);
            actual.ShouldBe(expected);
        }

        [Theory]
        [InlineData("abcabcbb", 3)]
        [InlineData("bbbbb", 1)]
        [InlineData("pwwkew", 3)]
        [InlineData("", 0)]
        public void Test_v3(string input, int expected)
        {
            int actual = LengthOfLongestSubstring_v3(input);
            actual.ShouldBe(expected);
        }
    }
}
