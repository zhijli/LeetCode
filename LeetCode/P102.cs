using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class P102
    {
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            var result = new List<IList<int>>();
            if (root == null) return result;

            var queue = new Queue<TreeNode>();
            queue.Enqueue(null);
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                var node = queue.Dequeue();
                if (node == null)
                {
                    if (queue.Count > 0)
                    {
                        result.Add(new List<int>());
                        queue.Enqueue(null);
                    }
                }
                else
                {
                    result.Last().Add(node.val);
                    if (node.left != null) queue.Enqueue(node.left);
                    if (node.right != null) queue.Enqueue(node.right);
                }
            }

            return result;
        }
    }
}
