using System;
using System.Collections;
using System.Linq;

namespace LeetCode.Problems
{
    public static class Problem0001
    {
        public static int[] TwoSum_v1(int[] nums, int target)
        {
            for(int i = 0; i < nums.Length; i++)
            {
                for(int j = i + 1; j < nums.Length; j++)
                {
                    if(nums[i] + nums[j] == target) return new[] { i, j };
                }
            }

            return Array.Empty<int>();
        }

        public static int[] TwoSum_v2(int[] nums, int target)
        {
            Hashtable map = new();

            for(int i = 0; i < nums.Length; i++)
            {
                int compliment = target - nums[i];

                if(map.ContainsKey(compliment))
                {
                    return new[] { (int)map[compliment]!, i };
                }

                if(!map.ContainsKey(nums[i]))
                {
                    map.Add(nums[i], i);
                }
            }

            return Array.Empty<int>();
        }

        public static int[] TwoSum_v3(int[] nums, int target) => nums
            .Select((x, i) => new[] { i, Array.LastIndexOf(nums, target - x) })
            .First(x => x[1] > x[0]);
    }
}
