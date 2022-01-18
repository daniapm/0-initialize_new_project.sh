using System;
using System.Collections.Generic;

class MatrixMath
{
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        double[,] mymatrix = new double[matrix1.GetLength(0), matrix2.GetLength(1)];

        if (matrix1.GetLength(1) != matrix2.GetLength(0))
        {
            return new double [,] {{-1}};
        }

        for (int i = 0; i < matrix2.GetLength(1); i++)
        {
            for (int j = 0; j < matrix1.GetLength(0); j++)
            {
                double sum = 0;
                for (int m = 0; m < matrix1.GetLength(1); m++)
                {
                    sum += Math.Round(matrix1[j, m] * matrix2[m, i], 2);
                }
                mymatrix[j, i] = sum;
            }
        }
        return mymatrix;
    }
}
