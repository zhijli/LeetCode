using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class P17
    {
        private static Dictionary<char, string> dic = new Dictionary<char, string>() {
            {'2',"abc"},
            {'3',"def"},
            {'4',"ghi"},
            {'5',"jkl"},
            {'6',"mno"},
            {'7',"pqrs"},
            {'8',"tuv"},
            {'9',"wxyz"},
        };

        public IList<string> LetterCombinations(string digits)
        {
            var tempResult = new List<string>() { string.Empty };
            var results = new List<string>();

            foreach (char digit in digits)
            {
                results = new List<string>();
                foreach (string result in tempResult)
                {
                    foreach (char c in dic[digit])
                    {
                        results.Add(result + c);
                    }
                }

                tempResult = results;
            }

            return results;
        }
    }
}
