using System;
using System.Collections.Generic;

class VectorMath
{
    public static double[] Add(double[] vector1, double[] vector2)
    {
        double[] result = new double[vector1.Length];
        foreach (double index1 in vector1)
        {
            int i;
            foreach(double index2 in vector2)
            {
                for (i = 0; i < vector1.Length; i++) {
                    result[i] = index1 + index2;
                }
            }
        }
        return Math.Round(result);
    }
}
