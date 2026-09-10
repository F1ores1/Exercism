using System.Security.Cryptography;

public class SpiralMatrix
{
    public static int[,] GetMatrix(int size)
    {
        int[,] spiralMatrix = new int[size, size];

        var unfilledTarget = size;
        var count = 1;
        var direction = 'R';
        var column = -1;
        var row = 0;
        while(unfilledTarget > 0)
        {
            for (int i = 0; i < unfilledTarget; i++)
            {
                switch (direction)
                {
                    case 'R':
                        column++;
                        break;

                    case 'D':
                        row++;
                        break;

                    case 'L':
                        column--;
                        break;

                    case 'U':
                        row--;
                        break;
                }
                spiralMatrix[row, column] = count;
                count++;
            }
            switch (direction)
            {
                case 'R':
                    direction = 'D';
                    unfilledTarget -= 1;
                    break;
                case 'D':
                    direction = 'L';
                    break;
                case 'L':
                    direction = 'U';
                    unfilledTarget -= 1;
                    break;
                case 'U':
                    direction = 'R';
                    break;
            }
        }
        return spiralMatrix;

    }
}
