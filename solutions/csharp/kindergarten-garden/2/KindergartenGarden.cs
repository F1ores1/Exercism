using System.Net.Security;

public enum Plant
{
    Violets = 'V',
    Radishes = 'R',
    Clover = 'C',
    Grass = 'G'
}



public class KindergartenGarden
{
    Dictionary<char, Plant> lookUp = new()
    {
        ['G'] = Plant.Grass,
        ['R'] = Plant.Radishes,
        ['C'] = Plant.Clover,
        ['V'] = Plant.Violets

    };
    private readonly List<string> students = new()
    {
        "Alice", "Bob", "Charlie", "David",
        "Eve", "Fred", "Ginny", "Harriet",
        "Ileana", "Joseph", "Kincaid", "Larry"
    };

    public List<IEnumerable<Plant>> cups = new();
    public KindergartenGarden(string diagram)
    {
        string[] rows = diagram.Split("\n");

        for (int i = 0; i < rows[0].Count(); i += 2)
        {
            List<Plant> cup = new()
            {
                lookUp[rows[0][i]],
                lookUp[rows[0][i+1]],
                lookUp[rows[1][i]],
                lookUp[rows[1][i+1]]
            };
            
            cups.Add(cup);
        }

    }

    public IEnumerable<Plant> Plants(string student)
    {
        return cups[students.IndexOf(student)];
    }
}