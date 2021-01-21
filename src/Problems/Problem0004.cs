using System;
using System.Collections.Generic;

namespace LeetCode.Problems
{
    public static class Problem0004
    {
        public static double FindMedianSortedArrays_v1(int[] nums1, int[] nums2)
        {
            var stack = new Stack<int>();
            int i = 0,
                j = 0;
            while(i + j <= (nums1.Length + nums2.Length) / 2)
            {
                if(i == nums1.Length && j < nums2.Length)
                {
                    stack.Push(nums2[j++]);
                }
                else if(j == nums2.Length && i < nums1.Length)
                {
                    stack.Push(nums1[i++]);
                }
                else if(nums1[i] < nums2[j])
                {
                    stack.Push(nums1[i++]);
                }
                else if(nums1[i] >= nums2[j])
                {
                    stack.Push(nums2[j++]);
                }
            }
            return (nums1.Length + nums2.Length) % 2 == 0
                ? (stack.Pop() + stack.Pop()) * 0.5
                : stack.Pop();
        }

        public static double FindMedianSortedArrays_v2(int[] nums1, int[] nums2)
        {
            int n = nums1.Length,
                m = nums2.Length;
            int l = (n + m + 1) / 2,
                r = (n + m + 2) / 2;
            return (GetKth(nums1, 0, n - 1, nums2, 0, m - 1, l) + GetKth(nums1, 0, n - 1, nums2, 0, m - 1, r)) * 0.5;
        }

        public static int GetKth(int[] nums1, int start1, int end1, int[] nums2, int start2, int end2, int k)
        {
            int len1 = end1 - start1 + 1,
                len2 = end2 - start2 + 1;
            if(len1 > len2)
            {
                return GetKth(nums2, start2, end2, nums1, start1, end1, k);
            }
            if(len1 == 0)
            {
                return nums2[start2 + k - 1];
            }
            if(k == 1)
            {
                return Math.Min(nums1[start1], nums2[start2]);
            }
            int i = start1 + Math.Min(len1, k / 2) - 1,
                j = start2 + Math.Min(len2, k / 2) - 1;
            if(nums1[i] > nums2[j])
            {
                return GetKth(nums1, start1, end1, nums2, j + 1, end2, k - (j - start2 + 1));
            }
            else
            {
                return GetKth(nums1, i + 1, end1, nums2, start2, end2, k - (i - start1 + 1));
            }
        }
    }
}
