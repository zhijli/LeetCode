namespace LeetCode
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class P131
    {
        private static List<IList<string>>[] dp;

        public IList<IList<string>> Partition(string s)
        {
            dp = new List<IList<string>>[s.Length];
            return Partition(s, s.Length - 1);
        }

        private List<IList<string>> Partition(string s, int index)
        {
            if (index == 0) return new List<IList<string>> { new List<string> { s.Substring(0, 1) } };
            if (index == -1) return new List<IList<string>> { new List<string>() };
            if (dp[index] != null) return dp[index];

            var result = new List<IList<string>>();
            for (int i = index; i >= 0; i--)
            {
                if (IsPalindrome(s, i, index))
                {
                    var subStr = s.Substring(i, index - i + 1);
                    var subResult = Partition(s, i - 1);

                    var temp = new List<IList<string>>();
                    subResult.ForEach(item => temp.Add(new List<string>(item)));
                    temp.ForEach(item => item.Add(subStr));
                    result.AddRange(temp);
                }
            }

            dp[index] = result;
            return result;
        }

        private bool IsPalindrome(string s, int left, int right)
        {
            while (left < right)
            {
                if (s[left] != s[right]) return false;
                left++;
                right--;
            }
            return true;
        }
    }
}
