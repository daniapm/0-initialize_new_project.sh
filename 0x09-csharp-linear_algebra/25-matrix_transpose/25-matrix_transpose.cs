using System;
using System.Collections.Generic;

class MatrixMath
{
    public static double[,] Transpose(double[,] matrix)
    {
        double[,] mymatrix = new double[matrix.GetLength(0), matrix.GetLength(1)];

        if (matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0)
        {
            return new double [,] {{}};
        }

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                mymatrix[j, i] = matrix[j, i];
            }
        }
        return mymatrix;
    }
}
