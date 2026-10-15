using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;

public class Matrix
{
    List<int[]> Rows;

    List<int[]> Columns;
    
    public Matrix(string input)
    {
        Rows = new();

        Columns = new();
        var rowCount = input.Count(x => x == '\n') + 1;

        var rows = input.Split('\n');

        Rows = rows
            .Select(r => r.Split(" "))
            .Select(n => n.Select(n => int.Parse(n)).ToArray())
            .ToList();

        for (int i = 0; i < Rows[0].Length; i++)
        {
            List<int> ints = new();
            for (int j = 0; j < rowCount; j++)
            {
                ints.Add(Rows[j][i]);
            }
            Columns.Add(ints.ToArray());
        }

        // int[,] matrix = new int[rows.Length, rowCount];

        // for (int i = 0; i < rowCount; i++)
        // {
        //     var numbers = rows[i].Split(" ");
        //     for (int j = 0; j < rows[i].Length; j++)
        //     {
        //         matrix[i, j] = int.Parse(numbers[j]);
        //     }
        // }

    }

    public int[] Row(int row)
    {

        return Rows[row-1];
    }

    public int[] Column(int col)
    {
        return Columns[col-1];
    }
}