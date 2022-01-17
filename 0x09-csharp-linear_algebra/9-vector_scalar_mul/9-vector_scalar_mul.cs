using System;
using System.Collections.Generic;

class VectorMath
{
    public static double[] Multiply(double[] vector, double scalar)
    {
        double[] result = new double[vector1.Length];
        if (vector.Length < 2 || vector.Length > 3)
        {
            return new double[] {-1};
        }
        
        for (int i = 0; i < vector.Length; i++)
        {
            result[i] = Math.Round(vector[i] * scalar, 2);
        }
        return result;
    }
}
