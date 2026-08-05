using System.Globalization;
using System.Reflection.PortableExecutable;

public class Robot
{
    public string Name
    {
        get; set;
    }

    public static List<string> Robots = new List<string>();

    public Robot()
    {
        var NewName = MakeName();
            
        while(Robots.Contains(NewName))
        {
            NewName = MakeName();
        }
        Name = NewName;
        Robots.Add(Name);
    }

    public void Reset()
    {
        var NewName = MakeName();

        while(NewName == Name)
        {
            NewName = MakeName();
        }
        Name = NewName;
    }

    string MakeName()
    {
        Random rnd = new Random();
        int number = rnd.Next(100,999);
        char firstLetter = Convert.ToChar(rnd.Next(65,91));
        char secondLetter = Convert.ToChar(rnd.Next(65,91));
        return $"{firstLetter}{secondLetter}{number}";
    }
}