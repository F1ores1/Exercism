public class HighScores
{
    public List<int> scores;
    public HighScores(List<int> list)
    {
        scores = list;
    }

    public List<int> Scores()
    {
        return scores;
    }

    public int Latest()
    {
        return scores.Last();
    }

    public int PersonalBest()
    {
        List<int> sort = new List<int>(scores);

        sort.Sort();

        return sort.Last();
    }

    public List<int> PersonalTopThree()
    {
        List<int> sort = new List<int>(scores);

        sort.Sort();

        List<int> topThree = new List<int>{};

        if (sort.Count >= 3)
        {
            for (int i = 0; i < sort.Count; i++)
            {
                if (i >= sort.Count - 3)
                {
                    topThree.Insert(0, sort[i]);
                }
                
            }            
        }
        else if (sort.Count == 2)
        {
            topThree.Insert(0, sort[0]);
            topThree.Insert(0, sort[1]);
        }
        else if (sort.Count == 1)
        {
            topThree.Insert(0, sort[0]);
        }
        return topThree;
    }
}