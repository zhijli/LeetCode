using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class P43
    {
        public string Multiply(string num1, string num2)
        {
            if (num1 == "0" || num2 == "0") return "0";

            var result = "";

            for (int i = num2.Length - 1; i >= 0; i--)
            {
                result = Plus(MultiplySingle(num1, num2[i]) , result);
                num1 = num1 + '0';
            }

            return result;
        }

        public string MultiplySingle(string num1, char single)
        {
            var result = "";
            int mul = single - '0';
            int op = 0;
            for (int i = num1.Length - 1; i >= 0; i--)
            {
                var val = (num1[i] - '0') * mul + op;
                op = val / 10;
                val = val % 10;

                result = (char)(val + '0') + result;
            }

            if (op > 0)
            {
                result = (char)(op + '0') + result;
            }

            return result;
        }

        public string Plus(string num1, string num2)
        {
            int op = 0;
            int i = num1.Length - 1;
            int j = num2.Length - 1;
            string result = "";

            while (i >= 0 && j >= 0)
            {
                var val = num1[i] - '0' + num2[j] - '0' + op;
                if (val >= 10)
                {
                    val -= 10;
                    op = 1;
                }
                else
                {
                    op = 0;
                }

                result = (char)(val + '0') + result;
                i--;
                j--;
            }

            while (i >= 0)
            {
                var val = num1[i] - '0' + op;
                if (val >= 10)
                {
                    val -= 10;
                    op = 1;
                }
                else
                {
                    op = 0;
                }

                result = (char)(val + '0') + result;
                i--;
            }

            while (j >= 0)
            {
                var val = num2[j] - '0' + op;
                if (val >= 10)
                {
                    val -= 10;
                    op = 1;
                }
                else
                {
                    op = 0;
                }

                result = (char)(val + '0') + result;
                j--;
            }

            if (op > 0)
            {
                result = '1' + result;
            }

            return result;
        }
    }
}
