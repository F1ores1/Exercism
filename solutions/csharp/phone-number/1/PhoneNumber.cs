public class PhoneNumber
{
    public static string Clean(string phoneNumber)
    {
    
        var numbers = phoneNumber.Where(c => Char.IsNumber(c)).ToList();

        if (numbers.Count() > 11)
        {
            throw new ArgumentException();
        }

        if (numbers.Count() < 10)
            throw new ArgumentException();

        if (numbers.Count() == 11)
        {
            if (numbers[0] != '1' || numbers[1] == '1')
            {
                throw new ArgumentException();
            }
            numbers.RemoveAt(0);
        }

        if (numbers[0] == '0' || numbers[0] == '1' || numbers[3] == '0' || numbers[3] == '1')
            throw new ArgumentException();

        return String.Join("", numbers);
    }
}