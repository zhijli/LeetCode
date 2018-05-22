using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class P122
    {
        public int MaxProfit(int[] prices)
        {
            var result = 0;
            var hasCash = true;

            var buyPrice = 0;
            for (int i = 0; i < prices.Length - 1; i++)
            {
                if (hasCash)
                {
                    if (prices[i] < prices[i + 1])
                    {
                        buyPrice = prices[i];
                        hasCash = false;
                    }
                }
                else
                {
                    if (prices[i] > prices[i + 1])
                    {
                        result += prices[i] - buyPrice;
                        hasCash = true;
                    }
                }
            }

            if (!hasCash)
            {
                result += prices[prices.Length - 1] - buyPrice;
            }

            return result;
        }
    }
}
