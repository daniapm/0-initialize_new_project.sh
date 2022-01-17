using System;
using System.Collections.Generic;

class VectorMath
{
    public static double Magnitude(double[] vector)
    {

        if (vector.Length < 2 || vector.Length > 3)
        {
            return -1;
        }
        double result = 0.0;   
        foreach (double index in vector)
        {
            result += (Math.Pow(index, 2));
        }
        return Math.Round(Math.Sqrt(result), 2);

    }

}
