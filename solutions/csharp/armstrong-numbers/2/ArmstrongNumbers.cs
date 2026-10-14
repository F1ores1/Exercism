public static class ArmstrongNumbers
{
    public static bool IsArmstrongNumber(int number)
        => number.ToString()
        .Sum(x => Math.Pow(char.GetNumericValue(x), number.ToString().Length)) == number;
}