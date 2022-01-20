using System;
using System.Collections.Generic;

class VectorMath
{
    public static double[] CrossProduct(double[] vector1, double[] vector2)
    {
        int lenvector1 = vector1.Length;
        int lenvector2 = vector2.Length;
        
        if (lenvector1 != 3 || lenvector2 != 3)
        {
            return new double[]{-1};
        }
        double[] myvector = new double[lenvector1];

        myvector = [vector1[1] * vector2[2] - vector1[2] * vector2[1], vector1[2] * vector2[0] - vector1[0] * vector2[2],
        vector1[0] * vector2[1] - vector1[1] * vector2[0]];

        return myvector;
    }
}
