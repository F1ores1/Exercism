public static class LargestSeriesProduct
{
    public static long GetLargestProduct(string digits, int span) 
    {
        if (span < 0 || span > digits.Length || !digits.All(char.IsDigit))
            throw new ArgumentException();

        if (span == 0)
            return 1;

        return Enumerable.Range(0, digits.Length - span + 1)
            .Select(c => digits
            .Substring(c, span)
            .Aggregate(1L, (acc, d) => acc * (long)char.GetNumericValue(d)))
            .OrderDescending()
            .ElementAt(0);
    }
}