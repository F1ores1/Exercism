using Microsoft.VisualBasic;

public static class PythagoreanTriplet
{
    public static IEnumerable<(int a, int b, int c)> TripletsWithSum(int sum)
    {
        int a = 0;
        int b = 0;
        int c = 0;

        for (int i = 1; i < sum/3; i++)
        {
            a = i;
            for (int j = a + 1; j < sum/2; j++)
            {
                b = j;
                c = sum - a - b;
                if (a*a + b*b == c * c)
                {
                    yield return (a, b, c);
                }
            }
        }


    }
}