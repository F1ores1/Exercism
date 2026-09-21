public static class CollatzConjecture
{
    public static int Steps(int number)
    {
        int steps = 0;

        while(number != 1)
        {
            if (steps > 1000001 || number < 1)
                throw new ArgumentOutOfRangeException();


            if (number % 2 == 0)
            {
                number = number / 2;
            }
            else
            {
                number = number * 3 + 1;
            }
            steps++;
        }

        return steps;
    }
}