public static class PrimeFactors
{
    public static long[] Factors(long number)
    {
        long temp = number;
        List<long> factors = new();
        for (int i = 2; i <= number; i++)
        {
            if (temp / i == 1 && temp % i == 0)
            {
                factors.Add(i);
                break;
            }
            else if (temp % i == 0)
            {
                temp = temp / i;
                factors.Add(i);
                i--;
            }
        }
        return factors.ToArray();
        throw new NotImplementedException("You need to implement this method.");
    }
}