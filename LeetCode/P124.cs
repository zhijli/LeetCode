namespace LeetCode
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    public class P124
    {
        private Dictionary<TreeNode, int> dp = new Dictionary<TreeNode, int>();

        public int MaxPathSum(TreeNode root)
        {
            if (root == null) return 0;

            var result = root.val + Math.Max(MaxSinglePathSumCurrent(root.left), 0) + Math.Max(MaxSinglePathSumCurrent(root.right), 0);

            if (root.left != null)
            {
                result = Math.Max(MaxPathSum(root.left), result);
            }

            if (root.right != null)
            {
                result = Math.Max(MaxPathSum(root.right), result);
            }

            return result;
        }

        private int MaxSinglePathSumCurrent(TreeNode current)
        {
            if (current == null) return 0;
            if (this.dp.ContainsKey(current)) return this.dp[current];

            var result = Math.Max(MaxSinglePathSumCurrent(current.left), 0);
            result = Math.Max(MaxSinglePathSumCurrent(current.right), result);
            result += current.val;
            this.dp.Add(current, result);
            return result;
        }
    }
}
