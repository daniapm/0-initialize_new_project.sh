using System;
using System.Collections.Generic;

class MatrixMath
{
    public static double Determinant(double[,] matrix)
    {
        int file = GetLength(0);
        int colum = GetLength(0);

        if (matrix.file < 2|| matrix.file > 3
        || matrix.colum < 2|| matrix.colum > 3)
        {
            return -1;
        }
        else if (matrix.file == 2 && matrix.colum == 2)
        {
            det = Math.Round((matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]));
            return(det);
        }
        else if (matrix.file == 3 && matrix.colum == 3)
        {
            det = Math.Round((matrix[0, 0] * ((matrix[1, 1] * matrix[2, 2]) - (matrix[1, 2] * matrix[2, 1]))) - (matrix[0, 1] * ((matrix[1, 0] * matrix[2, 2]) - (matrix[1, 2] * matrix[2, 0]))) + (matrix[0, 2] * ((matrix[1, 0] * matrix[2, 1]) - (matrix[1, 1] * matrix[2, 0]))), 2);
            return(det);
        }
    }
}
