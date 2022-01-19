using System;
using System.Collections.Generic;

class MatrixMath
{
    public static double[,] Transpose(double[,] matrix)
    {
        double[,] mymatrix = new double[matrix.GetLength(1), matrix.GetLength(0)];

        if (matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0)
        {
            return new double [,] {{}};
        }

        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                mymatrix[i, j] = matrix[j, i];
            }
        }
        return mymatrix;
    }
}
