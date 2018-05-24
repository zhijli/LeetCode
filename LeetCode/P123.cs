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

    public class P123
    {
        public int MaxProfit(int[] prices)
        {
            if (prices == null || prices.Length < 2) return 0;

            int[] dp1 = new int[prices.Length];
            int[] dp2 = new int[prices.Length];
            dp2[0] = 0;
            dp2[1] = Math.Max(prices[1] - prices[0], 0);

            int min = prices[0];
            int max = 0;
            var result = dp2[1];
            for (int i = 1; i < prices.Length; i++)
            {
                if (max < prices[i] - min)
                {
                    max = prices[i] - min;
                }
                if (min > prices[i])
                {
                    min = prices[i];
                }

                dp1[i] = max;
                if (i > 1)
                {
                    dp2[i] = Math.Max(dp1[i - 2] + prices[i] - prices[i - 1], dp2[i - 1] + prices[i] - prices[i - 1]);
                    if (result < dp2[i])
                    {
                        result = dp2[i];
                    }
                }
            }

            return result;
        }
    }
}
