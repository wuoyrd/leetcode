using Shouldly;
using Xunit;

namespace LeetCode.Problems
{
    using static Problem0004;

    public class Test0004
    {
        [Theory]
        [InlineData(new[] { 1, 3 }, new[] { 2 }, 2)]
        [InlineData(new[] { 1, 2 }, new[] { 3, 4 }, 2.5)]
        [InlineData(new[] { 0, 0 }, new[] { 0, 0 }, 0)]
        [InlineData(new int[0], new[] { 1 }, 1)]
        [InlineData(new[] { 2 }, new int[0], 2)]
        public void Test_v1(int[] nums1, int[] nums2, double expected)
        {
            double actual = FindMedianSortedArrays_v1(nums1, nums2);
            actual.ShouldBe(expected);
        }

        [Theory]
        [InlineData(new[] { 1, 3 }, new[] { 2 }, 2)]
        [InlineData(new[] { 1, 2 }, new[] { 3, 4 }, 2.5)]
        [InlineData(new[] { 0, 0 }, new[] { 0, 0 }, 0)]
        [InlineData(new int[0], new[] { 1 }, 1)]
        [InlineData(new[] { 2 }, new int[0], 2)]
        public void Test_v2(int[] nums1, int[] nums2, double expected)
        {
            double actual = FindMedianSortedArrays_v2(nums1, nums2);
            actual.ShouldBe(expected);
        }
    }
}
