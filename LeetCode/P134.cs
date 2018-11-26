namespace LeetCode
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class P134
    {
        public int CanCompleteCircuit(int[] gas, int[] cost)
        {
            var val = 0;
            var min = 0;
            int minIndex = -1;
            for (int i = 0; i < gas.Length; i++)
            {
                val = val + gas[i] - cost[i];
                if (val <= min)
                {
                    min = val;
                    minIndex = i;
                }
            }

            if (val >= 0)
            {
                return (minIndex + 1) % gas.Length;
            }
            else
            {
                return -1;
            }
        }
    }
}
