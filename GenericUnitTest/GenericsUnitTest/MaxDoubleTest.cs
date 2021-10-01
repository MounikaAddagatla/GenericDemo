using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsUnitTest
{
    class MaxDoubleTest
    {
        public double Max(double a, double b, double c)
        {
            if (a > b && a > c)
            {
                return a;
            }
            if (b > c && b > c)
            {
                return b;
            }
            return c;
        }
    }
}
