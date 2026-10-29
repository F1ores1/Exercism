using System.Drawing;

using Microsoft.VisualStudio.TestPlatform.Utilities;

public static class Rectangles
{
    public static int Count(string[] rows)
    {

        var rowCount = rows.Length;
        if (rowCount == 0)
            return 0;
        var colCount = rows[0].Length;
        var count = 0;



        for (int i = 0; i < rowCount; i++)
        {
            for (int j = 0; j < colCount; j++)
            {
                var original = rows[i][j];

                if (original != '+')
                    continue;

                rowMatch1(i, j);

            }
        }

        return count;

        void rowMatch1(int i, int j)
        {
            for (int x = i + 1; x < rowCount; x++)
            {
                var current = rows[x][j];

                if (current == '-' || current == ' ')
                    break;
                else if (current == '+')
                    colMatch(x, j, i, j);

            }
        }

        void colMatch(int i, int j, int oi, int oj)
        {
            for (int x = j + 1; x < colCount; x++)
            {
                var current = rows[i][x];

                if (current == '|' || current == ' ')
                    break;
                else if (current == '+')
                    rowMatch2(i, x, oi, oj);
            }
            
        }

        void rowMatch2(int i, int j, int oi, int oj)
        {
            for (int x = i -1 ; x >= 0; x--)
            {
                var current = rows[x][j];

                if (current == '-' || current == ' ')
                    break;
                else if (current == '+' && oi == x)
                    colMatch2(x, j, oi, oj);
                    
                    

            }
        }

        void colMatch2(int i, int j, int oi, int oj)
        {
            for (int x = j - 1; x >= 0; x--)
            {
                var current = rows[i][x];

                if (current == '|' || current == ' ')
                    break;
                else if (current == '+' && oj == x)
                    count++;
            }
        }


    }




}