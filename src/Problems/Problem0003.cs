using System;
using System.Collections.Generic;

namespace LeetCode.Problems
{
    public static class Problem0003
    {
        public static int LengthOfLongestSubstring_v1(string s)
        {
            if(s is not { Length: > 0 })
            {
                return 0;
            }
            var map = new Dictionary<char, int>();
            var len = 0;
            for(int i = 0, j = 0; i < s.Length; ++i)
            {
                if(map.ContainsKey(s[i]))
                {
                    j = Math.Max(j, map[s[i]] + 1);
                }
                map[s[i]] = i;
                len = Math.Max(len, i - j + 1);
            }
            return len;
        }

        public static int LengthOfLongestSubstring_v2(string s)
        {
            if(s is null)
            {
                return 0;
            }
            var queue = new Queue<char>();
            var len = 0;
            foreach(char c in s)
            {
                while(queue.Contains(c))
                {
                    queue.Dequeue();
                }
                queue.Enqueue(c);
                len = Math.Max(len, queue.Count);
            }
            return len;
        }

        public static int LengthOfLongestSubstring_v3(string s)
        {
            if(s is null)
            {
                return 0;
            }
            Span<int> map = stackalloc int[128];
            int len = 0;
            for(int i = 0, j = 0; i < s.Length;)
            {
                if(map[s[i++]]++ == 0)
                {
                    len = Math.Max(len, i - j);
                }
                else
                {
                    while(map[s[i - 1]] > 1)
                    {
                        map[s[j++]]--;
                    }
                }
            }
            return len;
        }
    }
}
