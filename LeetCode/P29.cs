// -----------------------------------------------------------------------
//  <copyright company="Microsoft">
//      Copyright (c) Microsoft Corporation.  All rights reserved.
//  </copyright>
// -----------------------------------------------------------------------

namespace LeetCode
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class P29
    {
        public int Divide(int dividend, int divisor)
        {
            if (dividend == Int32.MinValue && divisor == -1)
                return Int32.MaxValue;
            if (dividend == Int32.MinValue && divisor == 1)
                return Int32.MinValue;

            if (dividend > 0 && divisor > 0)
            {
                return DivideCore(-dividend, -divisor);
            }
            if (dividend < 0 && divisor > 0)
            {
                int value = this.DivideCore(dividend, -divisor);
                return -this.DivideCore(dividend, -divisor);
            }
            if (dividend > 0 && divisor < 0)
            {
                return -this.DivideCore(-dividend, divisor);
            }
            if (dividend < 0 && divisor < 0)
            {
                return this.DivideCore(dividend, divisor);
            }

            return 0;
        }

        private int DivideCore(int dividend, int divisor)
        {
            var scale = 1;
            var bounder = int.MinValue >> 1;

            while (bounder <= divisor && (dividend <= (divisor << 1)))
            {
                scale <<= 1;
                divisor <<= 1;
            }

            int result = 0;

            while (scale > 0)
            {
                if (dividend <= divisor)
                {
                    dividend -= divisor;
                    result += scale;
                }
                divisor >>= 1;
                scale >>= 1;
            }

            return result;
        }
    }
}
