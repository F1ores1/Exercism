using System.Diagnostics.Metrics;

using Microsoft.VisualBasic;

public static class BinarySearch
{
    public static int Find(int[] input, int value)
    {
        int[] sorted = input.Order().ToArray();

        var size = sorted.Count();

        var upperIndex = size;

        var lowerIndex = 0;

        var count = 0;

        if (size == 0)
            return -1;

        while (size > - 1)
        {
            var middleIndex = (upperIndex + lowerIndex) / 2;

            if (middleIndex > sorted.Count() -1 || middleIndex < 0)
                return -1;

            var middle = sorted[middleIndex];

            if (value == middle)
                return middleIndex;

            if (value > middle)
            {
                lowerIndex = middleIndex + 1;
            }
            else if (value < middle)
            {
                upperIndex = middleIndex - 1;
            }

            size = upperIndex - lowerIndex;

            count++;
            if (count > 10)
                throw new ArgumentException();
        }


        return -1;



    }
}