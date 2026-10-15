using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;

public class Matrix
{
    private readonly int[][] matrix;

    public Matrix(string input)
        => matrix = input.Split('\n')
            .Select(row => row.Split(' ').Select(int.Parse).ToArray())
            .ToArray();

    public int[] Row(int row)
    {

        return matrix[row-1];
    }

    public int[] Column(int col)
    {
        return matrix
            .Select(row => row[col -1])
            .ToArray();
    }
}