using System;
using System.Collections.Generic;

class VectorMath
{
    public static double[] Add(double[] vector1, double[] vector2)
    {
        double[] result = new double[vector1.Length];
        if (vector1.Length < 2 || vector1.Length > 3 || vector2.Length < 2 || vector2.Length > 3 || vector1.Length != vector2.Length)
        {
            return new double[] {-1};
        }
        
        for (int i = 0; i < vector1.Length; i++)
        {
            result[i] = Math.Round(vector1[i] + vector2[i], 2);
        }
        return result;
    }
}
