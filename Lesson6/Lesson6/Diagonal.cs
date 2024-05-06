using System;

public class Diagonal
{
    static void getDiagonal(int[,] mat, int n)
    {

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i == j)
                {
                    Console.Write(mat[i, j] + ", ");
                }
            }
        }
        Console.WriteLine("");
    }


    public static void Main(String[] args)
    {
        int n = 4;
        int[,] a = { { 1, 2, 3, 4 },
                    { 5, 6, 7, 8 },
                    { 1, 2, 3, 4 },
                    { 5, 6, 7, 8 } };

        getDiagonal(a, n);

    }
}
