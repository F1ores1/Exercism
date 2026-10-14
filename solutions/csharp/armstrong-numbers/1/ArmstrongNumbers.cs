public static class ArmstrongNumbers
{
    public static bool IsArmstrongNumber(int number)
    {
        

        return number.ToString()
            .Select(x => (int)Math.Pow(x - '0', number.ToString().Length)).Sum() == number;

        
    }
}