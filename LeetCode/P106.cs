using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class P106
    {
        public TreeNode BuildTree(int[] inorder, int[] postorder)
        {
            var dic = new Dictionary<int, int>();
            for (int i = 0; i < inorder.Length; i++)
            {
                dic.Add(inorder[i], i);
            }

            return BuildTree(inorder.Length - 1, postorder, 0, postorder.Length - 1, dic);
        }

        private TreeNode BuildTree(int iRight, int[] postorder, int pLeft, int pRight, Dictionary<int, int> dic)
        {
            if (pLeft > pRight) return null;

            var val = postorder[pRight];
            var indexI = dic[val];
            var indexP = indexI - iRight + pRight;

            var parent = new TreeNode(val);
            parent.left = BuildTree(indexI - 1, postorder, pLeft, indexP - 1, dic);
            parent.right = BuildTree(iRight, postorder, indexP, pRight - 1, dic);

            return parent;
        }
    }
}
