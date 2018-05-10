using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class P101
    {
        public bool IsSymmetric(TreeNode root)
        {
            if (root == null) return true;

            return IsSymmetric(root.left, root.right);
        }

        private bool IsSymmetric(TreeNode left, TreeNode right)
        {
            if (left == null || right == null)
            {
                if (left == right) return true;
                return false;
            }

            if (left.val != right.val) return false;
            return IsSymmetric(left.left, right.right) && IsSymmetric(left.right, right.left);
        }
    }
}
