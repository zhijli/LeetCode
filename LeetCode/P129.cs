namespace LeetCode
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class P129
    {
        public int SumNumbers(TreeNode root)
        {
            if (root == null) return 0;

            return SumNumbers(root, 0);
        }

        private int SumNumbers(TreeNode root, int current)
        {
            var val = current * 10 + root.val;
            if (root.left == null && root.right == null) return val;

            var result = 0;
            if (root.left != null) result += SumNumbers(root.left, val);
            if (root.right != null) result += SumNumbers(root.right, val);
            return result;
        }
    }
}
