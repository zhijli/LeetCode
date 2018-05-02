// -----------------------------------------------------------------------
//  <copyright company="Microsoft">
//      Copyright (c) Microsoft Corporation.  All rights reserved.
//  </copyright>
// -----------------------------------------------------------------------

namespace LeetCode
{
    using System;
    using System.CodeDom;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class P68
    {
        public IList<string> FullJustify(string[] words, int maxWidth)
        {
            var text = new List<List<string>>();
            var result = new List<string>();
            text.Add(new List<string> { words[0] });
            int wordsLength = words[0].Length;
            for (int i = 1; i < words.Length; i++)
            {
                if (wordsLength + words[i].Length + 1 <= maxWidth)
                {
                    wordsLength += words[i].Length + 1;
                    text.Last().Add(words[i]);
                }
                else
                {
                    result.Add(Justify(text.Last(), maxWidth));
                    text.Add(new List<string> { words[i] });
                    wordsLength = words[i].Length;
                }
            }
            result.Add(GenerateLastLine(text.Last(), maxWidth));
            return result;
        }

        private string GenerateLastLine(List<string> list, int maxWidth)
        {
            var str = list[0];

            for (int i = 1; i < list.Count; i++)
            {
                str += ' ' + list[i];
            }
            str += new string(' ', maxWidth - str.Length);

            return str;
        }

        private string Justify(List<string> strings, int maxWidth)
        {
            int wordsLength = 0;
            strings.ForEach(str => wordsLength += str.Length);
            if (strings.Count == 1)
            {
                return strings[0] + new string(' ', maxWidth - wordsLength);
            }
            else
            {
                var quotient = (maxWidth - wordsLength) / (strings.Count - 1);
                var remainder = (maxWidth - wordsLength) % (strings.Count - 1);
                var str = string.Empty;
                int i = 0;
                for (; i < strings.Count - 1; i++)
                {
                    if (i < remainder)
                    {
                        str = str + strings[i] + new string(' ', quotient + 1);
                    }
                    else
                    {
                        str = str + strings[i] + new string(' ', quotient);
                    }
                }
                str = str + strings[i];

                return str;
            }
        }
    }
}
