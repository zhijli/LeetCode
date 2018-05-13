using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class P105
    {
        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            var dic1 = new Dictionary<int, int>();
            for (int i = 0; i < inorder.Length; i++)
            {
                dic1.Add(inorder[i], i);
            }
            return BuildTree(preorder, 0, preorder.Length - 1, 0, dic1);
        }

        private TreeNode BuildTree(int[] preorder, int pleft, int pright, int ileft, Dictionary<int, int> dic1)
        {
            if (pleft > pright) return null;

            var val = preorder[pleft];
            var parent = new TreeNode(val);

            var indexP = dic1[val];
            var indexI = indexP - ileft + pleft;

            parent.left = BuildTree(preorder, pleft + 1, indexI, ileft, dic1);
            parent.right = BuildTree(preorder, indexI + 1, pright, indexP + 1, dic1);
            return parent;
        }
    }
}

