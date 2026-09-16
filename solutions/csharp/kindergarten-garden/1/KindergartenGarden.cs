using System.Net.Security;

public enum Plant
{
    Violets,
    Radishes,
    Clover,
    Grass
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
        switch (student)
        {
            case "Alice":
                return cups[0];
            case "Bob":
                return cups[1];
            case "Charlie":
                return cups[2];
            case "David":
                return cups[3];
            case "Eve":
                return cups[4];
            case "Fred":
                return cups[5];
            case "Ginny":
                return cups[6];
            case "Harriet":
                return cups[7];
            case "Ileana":
                return cups[8];
            case "Joseph":
                return cups[9];
            case "Kincaid":
                return cups[10];
            case "Larry":
                return cups[11];

            default:
                throw new ArgumentException();
        }
        throw new NotImplementedException("You need to implement this method.");
    }
}