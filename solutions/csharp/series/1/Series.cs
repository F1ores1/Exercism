public static class Series
{
    public static string[] Slices(string numbers, int sliceLength)
    {
        int cc = numbers.Count();
        
        int index = 0;

        if (sliceLength > cc)
            throw new ArgumentException();

        if (numbers.IsWhiteSpace())
            throw new ArgumentException();

        return slices().ToArray();

        IEnumerable<string> slices()
        {
            if (sliceLength < 1)
                throw new ArgumentException();

            while (index + sliceLength <= cc)
            {
                var subString = numbers.Substring(index, sliceLength);

                index += 1;

                yield return subString;
            }
     
        }

        
    }
}