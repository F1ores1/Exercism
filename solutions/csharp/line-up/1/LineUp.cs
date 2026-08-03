public static class LineUp
{
    public static string Format(string name, int number)
    {
        string lastDigits = number.ToString();

        if (number > 9)
            lastDigits = lastDigits.Substring(lastDigits.Length -2);
        string lastDigit = lastDigits.Substring(lastDigits.Length -1);

        string returnOrdinal = "th";

        List<string> exceptions = new List<string>{"11", "12", "13"};

        if (exceptions.Contains(lastDigits))
        {
            returnOrdinal = "th";
        }
        else if (lastDigit == "1")
        {
            returnOrdinal = "st";
        }
        else if (lastDigit == "2")
        {
            returnOrdinal = "nd";
        }
        else if (lastDigit == "3")
        {
            returnOrdinal = "rd";
        }
        
        return $"{name}, you are the {number}{returnOrdinal} customer we serve today. Thank you!";

    }
}
