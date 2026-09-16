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
    private readonly string _diagram;
    private readonly List<string> students = new()
    {
        "Alice", "Bob", "Charlie", "David",
        "Eve", "Fred", "Ginny", "Harriet",
        "Ileana", "Joseph", "Kincaid", "Larry"
    };

    public List<IEnumerable<Plant>> cups = new();
    public KindergartenGarden(string diagram)
    {
        _diagram = diagram;

    }

    public IEnumerable<Plant> Plants(string student)
    {
        int cup = students.IndexOf(student) * 2;
        return from line in _diagram.Split('\n')
            from plant in Enumerable.Range(cup, 2)
            select (Plant)line[plant];

    }
}