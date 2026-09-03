using System.Collections.Immutable;

using Microsoft.VisualBasic;

public class GradeSchool
{

    public IDictionary<string, int> RosterLookup = new Dictionary<string, int>();

    public bool Add(string student, int grade)
    {

        if (RosterLookup.ContainsKey(student))
        {
            return false;
        }

        RosterLookup.Add(student, grade);
        return true;

        
    }

    public IEnumerable<string> Roster()
    {
        return RosterLookup.OrderBy(x => x.Value).ThenBy(x => x.Key).Select(x => x.Key);

    }

    public IEnumerable<string> Grade(int grade)
    {
        // var sortRoster = Rosters[grade];
        // sortRoster.Sort();
        // return sortRoster;
        
        return RosterLookup.Where(x => x.Value == grade).OrderBy(x => x.Key).Select(x => x.Key);

    }
}