public static class CentralBank
{
    public static string DisplayDenomination(long @base, long multiplier)
    {
        long check;
        try
        {
            checked
            {
                check = @base * multiplier;
            }
        }
        catch (OverflowException)
        {
            return "*** Too Big ***";
        }
        return check.ToString();
    }

    public static string DisplayGDP(float @base, float multiplier)
    {
        float check;
        try
        {
            checked
            {
                check = @base * multiplier;
            }
            int checkint = checked((int)(@base * multiplier));
            
        }
        catch (OverflowException)
        {
            return "*** Too Big ***";
        }
        return check.ToString();
    }

    public static string DisplayChiefEconomistSalary(decimal salaryBase, decimal multiplier)
    {
        decimal check;
        try
        {
            checked
            {
                check = salaryBase * multiplier;
            }
            
        }
        catch (OverflowException)
        {
            return "*** Much Too Big ***";
        }
        return check.ToString();
    }
}
