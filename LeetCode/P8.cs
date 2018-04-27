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

    public class P8
    {
        public int MyAtoi(string str)
        {
            int result = 0;
            bool isNegative = false;
            bool start = false;
            bool isOverflow = false;
            for (int i = 0; i < str.Length; i++)
            {
                if (start == true)
                {
                    if (str[i] - '0' >= 0 && str[i] - '0' <= 9)
                    {
                        try
                        {
                            checked
                            {
                                // result = result * 10 + str[i] - '0';  Cause overflow for 2147483646!
                                result = result * 10 + (str[i] - '0');
                            }
                        }
                        catch (OverflowException)
                        {
                            isOverflow = true;
                        }
                    }
                    else
                    {
                       break;
                    }
                }
                else
                {

                    if (str[i] == ' ')
                    {
                        continue;
                    }
                    if (str[i] == '-')
                    {
                        isNegative = true;
                        start = true;
                    }
                    else if (str[i] == '+')
                    {
                        start = true;
                    }
                    else if (str[i] - '0' >= 0 && str[i] - '0' <= 9)
                    {
                        result = result * 10 + str[i] - '0';
                        start = true;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }

            if (isOverflow)
            {
              return  isNegative ? int.MinValue : Int32.MaxValue;
            }
            else
            {
                return isNegative ? -result : result;
            }
        }
    }
}
