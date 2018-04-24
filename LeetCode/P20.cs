using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class P20
    {

        public bool IsValid(string s)
        {
            var stack = new Stack<char>();

            foreach (var c in s)
            {
                if (c == '{' || c == '[' || c == '(')
                {
                    stack.Push(c);
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }
                    else
                    {
                        var c2 = stack.Pop();
                        if (!((c == '}' && c2 == '{') || (c == ']' && c2 == '[') || (c == ')' && c2 == '(')))
                        {
                            return false;
                        }
                    }
                }
            }

            if (stack.Count != 0)
            {
                return false;
            }
            return true;
        }
    }
}
