using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class P50
    {
        public double MyPow(double x, int n)
        {
            if (n == 0) return 1;
            if (n == 1) return x;

            if (n < 0)
            {
                if (n == int.MaxValue)
                {
                    return 1 / (MyPow(x, int.MaxValue) * x);
                }

                return 1 / MyPow(x, -n);
            }
            else
            {
                int a = 1;
                var temp = n;
                var result = x;
                while (temp > 1)
                {
                    temp >>= 1;
                    result *= result ;
                    a <<= 1;
                }
                var b = n % a;
                return result * MyPow(x, b);
            }
        }
    }
}
