
namespace LeetCode
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class P137
    {
        public int SingleNumber(int[] nums)
        {
            int result = 0;

            var a = new List<int>();
            for (int i = 0; i < 32; i++)
            {
                a.Insert(i, 0);
            }

            foreach (int num in nums)
            {
                var array = new BitArray(new int[] { num });
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i])
                    {
                        a[i] = (a[i] + 1) % 3;
                    }
                }
            }

            var weight = 1;
            for (int i = 0; i < a.Count; i++)
            {
                result += weight * a[i];
                weight *= 2;
            }

            return result;
        }
    }
}
