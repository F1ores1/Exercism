using Microsoft.VisualBasic;

public static class Dominoes
{
    public static bool CanChain(IEnumerable<(int, int)> dominoes)
    {
        if (dominoes.Count() == 0)
            return true;

        var dList = dominoes.ToList();
        var first = dList[0];
        if (dominoes.Count() == 1)
        {
            return first.Item1 == first.Item2;

        }
        dList.RemoveAt(0);
        var matches = 0;

        var matchFound = false;

        return Search(first, dList);

        bool Search((int, int) current, List<(int, int)> dList)
        {
            
            foreach (var d in dList)
            {
                if (Match(current, d))
                {
                    var nextList = new List<(int, int)>(dList);
                    nextList.Remove(d);
                    if (nextList.Count() == 0)
                        matchFound = true;

                    Search(d, nextList);

                }
            }
            return matchFound;


        }

        static bool Match((int, int) current, (int, int) next)
        {
            var item1 = current.Item1 == next.Item1;
            var mix1 = current.Item1 == next.Item2;
            var mix2 = current.Item2 == next.Item1;
            var item2 = current.Item2 == next.Item2;

            return item1 || mix1 || mix2 || item2;
        
        }

    }


}