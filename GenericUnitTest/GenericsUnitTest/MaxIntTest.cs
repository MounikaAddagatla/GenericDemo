using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsUnitTest
{
    class MaxIntTest
    {
        public int Max(int a, int b, int c)
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
