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

    public class P111
    {
        public int MinDepth(TreeNode root)
        {
            if (root == null) return 0;

            if (root.left == null) return MinDepth(root.right) + 1;

            if (root.right == null) return MinDepth(root.left) + 1;

            return Math.Min(MinDepth(root.left), MinDepth(root.right)) + 1;
        }
    }
}
