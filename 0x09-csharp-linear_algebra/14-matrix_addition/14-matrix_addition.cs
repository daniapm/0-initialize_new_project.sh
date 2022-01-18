using System;
using System.Collections.Generic;

class VectorMath
{
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        double[,] mymatrix = new double[matrix1.GetLength(0), matrix1.GetLength(1)];

        if (matrix1.GetLength(0) != matrix2.GetLength(0)
        || matrix1.GetLength(0) < 2 || matrix1.GetLength(0) > 3
        || matrix2.GetLength(0) < 2 || matrix2.GetLength(0) > 3
        || matrix1.GetLength(1) < 2 || matrix1.GetLength(1) > 3
        || matrix2.GetLength(1) < 2 || matrix2.GetLength(1) > 3)
        {
            return new double [,] {{-1}};
        }

        for (int i = 1; i < matrix1.GetLength(0); i++)
        {
            for (int j = 1; j < matrix1.GetLength(1); j++)
            {
                mymatrix[i, j] = Math.Round(matrix1[i,j] + matrix2[i,j], 2);
                Console.WriteLine(mymatrix[i, j]);
            }
        }
        return mymatrix;
    }

    static void Main(string[] args)
    {
        double[,] myvector1 = new double[2, 3] { { 10, 5, 100 }, { 50, 75, 25 } };
        double[,] myvector2 = new double[2, 3] { { 7, 3, 5 }, { 4, 7, 5 } };
        VectorMath.Add(myvector1, myvector2);

        Console.WriteLine(Add(myvector1, myvector2));
    }
}
