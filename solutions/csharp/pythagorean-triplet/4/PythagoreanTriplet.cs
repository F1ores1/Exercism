using Microsoft.VisualBasic;

public static class PythagoreanTriplet
{
    public static IEnumerable<(int a, int b, int c)> TripletsWithSum(int sum)
    {
        int a = 0;
        int b = 0;
        int c = 0;
        int sumSquare = (int)Math.Pow(sum, 2);

        for (int i = 0; i < sum/2; i++)
        {
            a = i;
            var aSqaure = (int)Math.Pow(a, 2);
            for (int j = a + 1; j < sum/2; j++)
            {
                b = j;
                var bSqaure = (int)Math.Pow(b, 2);

                var doubleC = Math.Sqrt(aSqaure + bSqaure);
                var floorC = Math.Floor(doubleC);
                c = (int)floorC;

                if (a + b + c == sum && c > b && doubleC == floorC)
                {
                    yield return (a, b, c);
                }
            }
        }
        // for (int i = 0; i < sum; i++)
        // {
        //     a = (int)Math.Pow(i+ 1, 2)- (int)Math.Pow(i, 2);
        //     b = 2*(i+1)*i;
        //     c = (int)Math.Pow(i + 1, 2) + (int)Math.Pow(i, 2);

        //     for (int k = 0; k < sum; k++)
        //     {
        //         int calc_A = a * k;
        //         int calc_B = b * k;
        //         int calc_C = c * k;
        //         if (calc_A + calc_B + calc_C == sum && calc_A < calc_B && calc_B < calc_C)
        //         {
        //             yield return (calc_A, calc_B, calc_C);
        //         }
        //     }


        // }



    }
}