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

    public class P114
    {
        public void Flatten(TreeNode root)
        {
            if (root == null) return;
            FlattenCore(root);
        }

        private TreeNode FlattenCore(TreeNode node)
        {
            var nodeRight = node.right;
            var returnNode = node;
            if (node.left != null)
            {
                var leftReturn = FlattenCore(node.left);
                leftReturn.right = node.right;
                node.right = node.left;
                node.left = null;
                returnNode = leftReturn;
            }
            
            if (nodeRight != null)
            {
                returnNode = FlattenCore(nodeRight);
                
            }

            return returnNode;
        }
    }
}
