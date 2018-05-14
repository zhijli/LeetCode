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

    public class P109
    {
        public TreeNode SortedListToBST(ListNode head)
        {
            var nums = new List<int>();
            var current = head;
            while (current != null)
            {
                nums.Add(current.val);
                current = current.next;
            }

            return SortedListToBST(nums, 0, nums.Count - 1);
            ;
        }

        private TreeNode SortedListToBST(List<int> nums, int left, int right)
        {
            if (left > right) return null;

            var mid = (left + right) / 2;
            var parent = new TreeNode(nums[mid]);

            parent.left = SortedListToBST(nums, left, mid - 1);
            parent.right = SortedListToBST(nums, mid + 1, right);
            return parent;
        }
    }
}
