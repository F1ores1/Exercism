public static class Grains
{
    public static long[] squares = new long[64];
    public static ulong Square(int n)
    {
        if (n < 1 || n > 64)
            throw new ArgumentOutOfRangeException();

        return (ulong)Math.Pow(2, n - 1);
    }

    public static ulong Total()
    {
        ulong count = 0;
        for (int i = 1; i <= 64; i++)
        {
            count = count + Square(i);
        }
        return count;
    }
}