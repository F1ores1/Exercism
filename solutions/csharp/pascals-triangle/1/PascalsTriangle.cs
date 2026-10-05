public static class PascalsTriangle
{
    public static IEnumerable<IEnumerable<int>> Calculate(int rows)
    {
        List<int> prev = new();
        List<int> current = new();

        for (int r = 0; r < rows; r++)
        {
            for (int i = 0; i <= r; i++)
            {
                if (i == 0 || i == r)
                {
                    current.Add(1);
                }
                else
                {
                    var sum = prev[i-1] + prev[i];
                    current.Add(sum);
                }
            }
            yield return current;
            prev = current;
            current = new();
        }
    }

}