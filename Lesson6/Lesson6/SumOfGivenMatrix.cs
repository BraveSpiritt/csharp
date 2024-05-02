using System;

public class MatrixCalculator
{
    public int CalculateMatrixSum(int[,] matrix)
    {
        int sum = 0;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                sum += matrix[i, j];
            }
        }

        return sum;
    }

    public static void Main(string[] args)
    {
        int[,] matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        MatrixCalculator calculator = new MatrixCalculator();
        int sum = calculator.CalculateMatrixSum(matrix);

        Console.WriteLine($"The sum of all elements in the matrix is: {sum}");
    }
}
