using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LeetCode
{
    public class P49
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var dic = new Dictionary<string, IList<string>>();
            foreach (string str in strs)
            {
                string sortedStr = Sort(str);

                if (dic.ContainsKey(sortedStr))
                {
                    dic[sortedStr].Add(str);
                }
                else
                {
                    dic[sortedStr] = new List<string> { str };
                }
            }

            return dic.Values.ToList();
        }

        private string Sort(string str)
        {
            char[] sorted = str.ToCharArray();
            Array.Sort(sorted);
            return new string(sorted);
        }
    }
}
