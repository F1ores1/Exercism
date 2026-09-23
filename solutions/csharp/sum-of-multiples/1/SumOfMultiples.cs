public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        multiples = multiples.Where(x => x > 0);

        return Enumerable.Range(0, max)
            .Where( x=> multiples.Any(m => x % m == 0) && x < max)
            .Sum();
    }
}