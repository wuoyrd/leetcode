namespace LeetCode.Problems
{
    public static class Problem0005
    {
        public static int Reverse_v1(int x)
        {
            int result = 0;
            while(x != 0)
            {
                try
                {
                    checked
                    {
                        result *= 10;
                        result += x % 10;
                    }
                }
                catch
                {
                    return 0;
                }
                x /= 10;
            }
            return result;
        }

        public static int Reverse_v2(int x, int result = 0)
        {
            try
            {
                checked
                {
                    return x == 0 ? result : Reverse_v2(x / 10, result * 10 + x % 10);
                }
            }
            catch
            {
                return 0;
            }
        }
    }
}
