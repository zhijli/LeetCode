using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class P89
    {

        public IList<int> GrayCode(int n)
        {
            int length = (int)Math.Pow(2, n);
            int[] array = new int[n];
            var dic = new Dictionary<int, bool>();
            dic.Add(0, true);
            for (int i = 1; i < length; i++)
            {
                dic.Add(i, false);
            }

            var result = new List<int> { 0 };
            GrayCode(array, 1, length, dic, result);
            return result;
        }

        private bool GrayCode(int[] array, int index, int length, Dictionary<int, bool> dic, List<int> result)
        {
            if (index == length) return true;

            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] == 0)
                {
                    array[i] = 1;
                }
                else
                {
                    array[i] = 0;
                }

                var num = BitToInt(array);
                if (dic[num] == false)
                {
                    dic[num] = true;
                    result.Add(num);
                    if (GrayCode(array, index + 1, length, dic, result))
                    {
                        return true;
                    }
                    dic[num] = false;
                    result.Remove(num);
                }
                if (array[i] == 0)
                {
                    array[i] = 1;
                }
                else
                {
                    array[i] = 0;
                }

            }
            return false;
        }

        private int BitToInt(int[] array)
        {
            var result = 0;
            var baseInt = 1;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                result += array[i] * baseInt;
                baseInt *= 2;
            }

            return result;
        }
    }
}
