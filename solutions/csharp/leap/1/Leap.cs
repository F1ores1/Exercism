public static class Leap
{
    public static bool IsLeapYear(int year)
    {
        int normal = year % 4;
        int century = year % 100;
        int fourhundred = year % 400;


        if (century == 0 && fourhundred == 0)
        {
            return true;
        }
        else if (century == 0 && fourhundred != 0)
        {
            return false;
        }
        else if (normal == 0)
        {
            return true;
        }
        else return false;
        
    }
}