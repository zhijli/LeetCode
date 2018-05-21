using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class P113
    {
        public IList<IList<int>> PathSum(TreeNode root, int sum)
        {
            var result = new List<IList<int>>();
            var current = new List<int>();
            PathSum(root, sum, current, result);
            return result;
        }

        private void PathSum(TreeNode root, int sum, List<int> current, List<IList<int>> result)
        {
            if (root == null) return;
            if (root.left == null && root.right == null)
            {
                if (root.val == sum)
                {
                    current.Add(sum);
                    result.Add(current);
                }
                return;
            }

            current.Add(root.val);
            if (root.left == null)
            {
                PathSum(root.right, sum - root.val, new List<int>(current)  , result);
                return;
            }
            if (root.right == null)
            {
                PathSum(root.left, sum - root.val, new List<int>(current), result);
                return;
            }

            PathSum(root.right, sum - root.val, new List<int>(current), result);
            PathSum(root.left, sum - root.val, new List<int>(current), result);
        }
    }
}
