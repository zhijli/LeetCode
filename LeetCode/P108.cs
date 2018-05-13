using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class P108
    {
        public TreeNode SortedArrayToBST(int[] nums)
        {
            return SortedArrayToBST(nums, 0, nums.Length - 1);
        }

        private TreeNode SortedArrayToBST(int[] nums, int left, int right)
        {
            if (left > right) return null;

            var mid = (left + right) / 2;

            var parent = new TreeNode(nums[mid]);

            parent.left = SortedArrayToBST(nums, left, mid - 1);
            parent.right = SortedArrayToBST(nums, mid + 1, right);

            return parent;
        }
    }
}
