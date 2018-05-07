using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class P100
    {
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == q) return true;
            if (p == null) return false;
            if (q == null) return false;

            return (p.val == q.val && IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right));
        }
    }
}
