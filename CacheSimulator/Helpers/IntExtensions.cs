namespace CacheSimulator
{
    public static class IntExtensions
    {
        public static bool IsPowerOfTwo(this int x) 
            => (x != 0) && ((x & (x - 1)) == 0);
    }
}
