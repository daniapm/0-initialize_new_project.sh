using System;
using System.Collections.Generic;

class MatrixMath
{
    public static double Determinant(double[,] matrix)
    {
        if (matrix.GetLength(0) < 2|| matrix.GetLength(0) > 3
        || matrix.GetLength(1) < 2|| matrix.GetLength(1) > 3)
        {
            return -1;
        }

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            det = det + (matrix[0,i]*(matrix[1,(i+1)%3]*matrix[2,(i+2)%3] - matrix[1,(i+2)%3]*matrix[2,(i+1)%3]));
        }
        return det;
    }
}
