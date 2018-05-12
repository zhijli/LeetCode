using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class P103
    {
        public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {
            var result = new List<IList<int>>();
            if (root == null) return result;

            var stack1 = new Stack<TreeNode>();
            var stack2 = new Stack<TreeNode>();

            stack1.Push(root);
            while (stack1.Count > 0 || stack2.Count > 0)
            {
                if (stack1.Count != 0)
                {
                    result.Add(new List<int>());
                }

                while (stack1.Count > 0)
                {
                    var node = stack1.Pop();
                    result.Last().Add(node.val);
                    if (node.left != null) stack2.Push(node.left);
                    if (node.right != null) stack2.Push(node.right);
                }

                if (stack2.Count != 0)
                {
                    result.Add(new List<int>());
                }

                while (stack2.Count > 0)
                {
                    var node = stack2.Pop();
                    result.Last().Add(node.val);
                    if (node.right != null) stack1.Push(node.right);
                    if (node.left != null) stack1.Push(node.left);
                }
            }

            return result;
        }
    }
}
