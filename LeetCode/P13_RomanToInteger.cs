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

    class P13_RomanToInteger
    {
        public int RomanToInt(string s)
        {
            var dic = new Dictionary<char,int>()
            {
                { 'I',1}, {'V',5 }, {'X',10 }, {'L',50 }, {'C',100}, {'D',500 }, {'M',1000 }
            };

            var result = 0;
            int current = 0;
            while (current < s.Length)
            {
                var value = dic[s[current]];
                current++;
                if (current < s.Length)
                {
                    var nextValue = dic[s[current]];
                    if (value < nextValue)
                        value = -value;
                }

                result += value;
            }

            return result;
        }
    }
}
