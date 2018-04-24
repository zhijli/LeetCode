using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class P22
    {
        public IList<string> GenerateParenthesis(int n)
        {
            var results = new List<string>();
            var stack = new Stack<char>();
            GenerateParenthesis(stack, n, results, "");
            return results;
        }

        private void GenerateParenthesis(Stack<char> stack, int n, List<string> results, string result)
        {
            if (n == 0 && stack.Count == 0)
            {
                results.Add(result);
            }

            if (n > 0)
            {
                stack.Push('(');
                GenerateParenthesis(new Stack<char>(stack), n - 1, results, result + '(');
                stack.Pop();
            }
            if (stack.Count > 0)
            {
                stack.Pop();
                GenerateParenthesis(new Stack<char>(stack), n, results, result + ')');
            }
        }
    }
}
