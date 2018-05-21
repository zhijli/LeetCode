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
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    public class P110
    {
        public bool IsBalanced(TreeNode root)
        {
            int hight;
            return IsBalanced(root, out hight);
        }

        private bool IsBalanced(TreeNode root, out int hight)
        {
            if (root == null)
            {
                hight = 0;
                return true;
            }

            int leftHight;
            int rightHight;
            if (IsBalanced(root.left, out leftHight) && IsBalanced(root.right, out rightHight) && Math.Abs(leftHight - rightHight) <=1)
            {
                hight = Math.Max(leftHight, rightHight) + 1;
                return true;
            }
            //Do not care the hight when return false;
            hight = 0;
            return false;
        }
    }
}
