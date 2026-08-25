using System.Collections.Immutable;

using Microsoft.VisualBasic;

public class GradeSchool
{

    public IDictionary<int, List<string>> Rosters 
        = new Dictionary<int, List<string>>
        {
            {1, new List<string>()},
            {2, new List<string>()},
            {3, new List<string>()},
            {4, new List<string>()},
            {5, new List<string>()},
            {6, new List<string>()},
            {7, new List<string>()},
            {8, new List<string>()},

        };
    public bool Add(string student, int grade)
    {
        foreach (var gradeRoster in Rosters)
        {
            if (Rosters[gradeRoster.Key].Contains(student))
            {
                return false;
            }
        }

        Rosters[grade].Add(student);
        return true;

        
    }

    public IEnumerable<string> Roster()
    {
        List<int> grades = Rosters.Keys.ToList();

        grades.Sort();

        var finalRoster = new List<string>();

        foreach (var grade in grades)
        {
            finalRoster.AddRange(Grade(grade));
        }
        return finalRoster;
    }

    public IEnumerable<string> Grade(int grade)
    {
        var sortRoster = Rosters[grade];
        sortRoster.Sort();
        return sortRoster;
    }
}