// -----------------------------------------------------------------------
//  <copyright company="Microsoft">
//      Copyright (c) Microsoft Corporation.  All rights reserved.
//  </copyright>
// -----------------------------------------------------------------------

namespace LeetCode
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class P99
    {
        public void RecoverTree(TreeNode root)
        {
            TreeNode pre = null;
            TreeNode first = null;
            TreeNode second = null;
            bool getFirst = false;
            var current = root;
            var stack = new Stack<TreeNode>();

            while (current != null || stack.Count > 0)
            {
                while (current != null)
                {
                    stack.Push(current);
                    current = current.left;
                }

                current = stack.Pop();
                if (getFirst == false && pre != null && pre.val > current.val)
                {
                    first = pre;
                    getFirst = true;
                }

                if (pre != null && pre.val > current.val)
                {
                    second = current;
                }

                pre = current;
                current = current.right;
            }

            if (first != null && second != null)
            {
                var temp = first.val;
                first.val = second.val;
                second.val = temp;
            }
        }
    }
}
