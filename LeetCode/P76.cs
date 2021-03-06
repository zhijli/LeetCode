﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class P76
    {
        public string MinWindow(string s, string t)
        {
            if (string.IsNullOrEmpty(t)) return s;
            if (string.IsNullOrEmpty(s)) return "";

            int i = 0, j = 0;
            int min = int.MaxValue;
            int minLeft = 0;
            int minRight = -1;
            //Imporve: No need to use int?, just think required count is 0 for thos char not in t 
            int[] dic = new int[128];

            foreach (char c in t)
            {
                dic[c]++;
            }

            var containCount = t.Length;

            dic[s[0]]--;
            if (dic[s[0]] >= 0)
            {
                containCount--;
            }

            while (i < s.Length && j < s.Length)
            {
                if (containCount > 0)
                {
                    j++;
                    if (j < s.Length)
                    {
                        dic[s[j]]--;
                        if (dic[s[j]] >= 0)
                        {
                            containCount--;
                        }
                    }
                }
                else
                {
                    if (j - i + 1 < min)
                    {
                        min = j - i + 1;
                        minLeft = i;
                        minRight = j;
                    }
                    if (i < s.Length)
                    {
                        dic[s[i]]++;
                        if (dic[s[i]] > 0)
                        {
                            containCount++;
                        }
                    }
                    i++;
                }
            }

            return s.Substring(minLeft, minRight - minLeft + 1);
        }
    }
}
