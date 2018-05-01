using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class P7_ReverseInteger
    {
        public int Reverse(int x)
        {


            if (x >= 0)
            {
                return ReverseCore(x);
            }
            else
            {
                return -ReverseCore(-x);
            }
        }

        private int ReverseCore(int x)
        {
            var result = 0;
            var i = 0;
            while (x > 0)
            {
                i = x % 10;
                x = x / 10;
                try
                {
                    checked { result = result * 10 + i; }
                }
                catch (OverflowException)
                {
                    return 0;
                }
            }

            return result;
        }
    }
}
