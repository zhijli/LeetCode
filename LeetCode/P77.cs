using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class P77
    {
        public IList<IList<int>> Combine(int n, int k)
        {
            bool[] ban = new bool[n + 1];
            return Combine(n, k, ban);
        }

        private List<IList<int>> Combine(int n, int k, bool[] ban)
        {
            if (k == 0) return new List<IList<int>> { new List<int>() };
            bool[] newBan = new bool[n+1];
            ban.CopyTo(newBan,0);
            var result = new List<IList<int>>();
            for (int i = 1; i <= n; i++)
            {
                if (newBan[i] == false)
                {
                    newBan[i] = true;
                    Combine(n, k - 1, newBan).ForEach(item => result.Add(new List<int>(item) { i }));
                }
            }

            return result;
        }
    }
}
