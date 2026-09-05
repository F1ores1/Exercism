public static class Grains
{
    public static long[] squares = new long[64];
    public static ulong Square(int n)
    {
        if (n < 1 || n > 64)
            throw new ArgumentOutOfRangeException();
        return 1UL << (n - 1);
    }
    public static ulong Total()
    {
        ulong count = 0;
        for (int i = 1; i <= 64; i++)
        {
            count += Square(i);
        }
        return count;
    }
}