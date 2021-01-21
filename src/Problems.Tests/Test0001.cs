using Shouldly;
using Xunit;

namespace LeetCode.Problems
{
    public class Test0001
    {
        [Theory]
        [InlineData(new[] { 2, 7, 11, 15 }, 9, new[] { 0, 1 })]
        [InlineData(new[] { 3, 2, 4 }, 6, new[] { 1, 2 })]
        [InlineData(new[] { 3, 3 }, 6, new[] { 0, 1 })]
        public void Test_v1(int[] nums, int target, int[] expected)
        {
            int[] actual = Problem0001.TwoSum_v1(nums, target);
            actual.ShouldBe(expected);
        }

        [Theory]
        [InlineData(new[] { 2, 7, 11, 15 }, 9, new[] { 0, 1 })]
        [InlineData(new[] { 3, 2, 4 }, 6, new[] { 1, 2 })]
        [InlineData(new[] { 3, 3 }, 6, new[] { 0, 1 })]
        public void Test_v2(int[] nums, int target, int[] expected)
        {
            int[] actual = Problem0001.TwoSum_v2(nums, target);
            actual.ShouldBe(expected);
        }

        [Theory]
        [InlineData(new[] { 2, 7, 11, 15 }, 9, new[] { 0, 1 })]
        [InlineData(new[] { 3, 2, 4 }, 6, new[] { 1, 2 })]
        [InlineData(new[] { 3, 3 }, 6, new[] { 0, 1 })]
        public void Test_v3(int[] nums, int target, int[] expected)
        {
            int[] actual = Problem0001.TwoSum_v3(nums, target);
            actual.ShouldBe(expected);
        }
    }
}
