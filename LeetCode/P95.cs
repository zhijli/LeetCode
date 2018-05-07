using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class P95
    {
        public IList<TreeNode> GenerateTrees(int n)
        {
            if (n == 0) return new List<TreeNode>();

            var list = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                list.Add(i);
            }
            return GenerateTrees(list, 0, n - 1);
        }

        private IList<TreeNode> GenerateTrees(List<int> list, int left, int right)
        {
            if (left == right) return new List<TreeNode> { new TreeNode(list[left]) };
            if (left > right) return new List<TreeNode> { null };

            var result = new List<TreeNode>();
            for (int i = left; i <= right; i++)
            {
                foreach (TreeNode leftNode in GenerateTrees(list, left, i - 1))
                {
                    foreach (var rightNode in GenerateTrees(list, i + 1, right))
                    {
                        var node = new TreeNode(list[i]);
                        node.left = leftNode;
                        node.right = rightNode;
                        result.Add(node);
                    }
                }
            }
            return result;
        }
    }
}
