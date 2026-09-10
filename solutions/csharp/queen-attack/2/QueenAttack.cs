using System.Reflection.Emit;

public class Queen
{
    public Queen(int row, int column)
    {
        Row = row;
        Column = column;
    }

    public int Row { get; }
    public int Column { get; }
}

public static class QueenAttack
{
    public static bool CanAttack(Queen white, Queen black)
    {
        if (white.Row == black.Row)
        {
            return true;
        }
        else if (white.Column == black.Column)
        {
            return true;
        }

        var deltaRow = Math.Abs(white.Row - black.Row);

        var deltaColumn = Math.Abs(white.Column - black.Column);

        if (deltaRow == deltaColumn)
        {
            return true;
        }

        return false;
       
    }

    public static Queen Create(int row, int column)
    {
        int[,] board = new int[8, 8];
        try
        {
            board[row, column] = 1;
        }
        catch (Exception e)
        {
            throw new ArgumentOutOfRangeException(e.Message);
        }

        
        return new Queen(row, column);
    }
}