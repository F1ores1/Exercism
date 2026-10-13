using Microsoft.VisualBasic;

public static class PythagoreanTriplet
{
    public static IEnumerable<(int a, int b, int c)> TripletsWithSum(int sum)
    {
        int a = 0;
        int b = 0;
        int c = 0;
        int sumSquare = (int)Math.Pow(sum, 2);

        // for (int i = 0; i < sum/2; i++)
        // {
        //     a = i;
        //     var aSqaure = (int)Math.Pow(a, 2);
        //     for (int j = a + 1; j < sum/2; j++)
        //     {
        //         b = j;
        //         var bSqaure = (int)Math.Pow(b, 2);

        //         var doubleC = Math.Sqrt(aSqaure + bSqaure);
        //         var floorC = Math.Floor(doubleC);
        //         c = (int)floorC;

        //         if (a + b + c == sum && c > b && doubleC == floorC)
        //         {
        //             yield return (a, b, c);
        //         }
        //     }
        // }
        for (int i = 0; i < sum; i++)
        {
            a = (int)Math.Pow(i+ 1, 2)- (int)Math.Pow(i, 2);
            b = 2*(i+1)*i;
            c = (int)Math.Pow(i + 1, 2) + (int)Math.Pow(i, 2);

            if (a + b + c == sum)
            {
                yield return (a, b, c);
            }
        }



    }
}