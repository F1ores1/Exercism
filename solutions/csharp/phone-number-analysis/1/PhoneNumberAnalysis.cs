using Microsoft.VisualBasic;

public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        var splitnumber = phoneNumber.Split('-');
        bool IsNewYork = splitnumber[0] == "212";
        bool IsFake = splitnumber[1] == "555";
        string LocalNumber = splitnumber[2];
        return (IsNewYork, IsFake, LocalNumber);
        throw new NotImplementedException($"Please implement the (static) PhoneNumber.Analyze() method");
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        return phoneNumberInfo.IsFake;

        throw new NotImplementedException($"Please implement the (static) PhoneNumber.IsFake() method");
    }
}
