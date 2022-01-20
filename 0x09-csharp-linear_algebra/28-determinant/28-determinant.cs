using System;
using System.Collections.Generic;

class MatrixMath
{
    public static double Determinant(double[,] matrix)
    {
        int file = matrix.GetLength(0);
        int colum = matrix.GetLength(1);

        if (file < 2|| file > 3
        || colum < 2|| colum > 3)
        {
            return -1;
        }
        double det = 0;
        
        else if (file == 2 && colum == 2)
        {
            det = Math.Round((matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]), 2);
            return(det);
        }
        else if (file == 3 && colum == 3)
        {
            det = Math.Round((matrix[0, 0] * ((matrix[1, 1] * matrix[2, 2]) - (matrix[1, 2] * matrix[2, 1]))) - (matrix[0, 1] * ((matrix[1, 0] * matrix[2, 2]) - (matrix[1, 2] * matrix[2, 0]))) + (matrix[0, 2] * ((matrix[1, 0] * matrix[2, 1]) - (matrix[1, 1] * matrix[2, 0]))), 2);
            return(det);
        }
    }
}
