
namespace LeetCode
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class P136
    {
        public int SingleNumber(int[] nums)
        {
            int result = 0;

            foreach (int num in nums)
            {
                result ^= num;
            }

            return result;
        }
    }
}
