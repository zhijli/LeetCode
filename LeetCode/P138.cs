
namespace LeetCode
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using LeetCode.Model;

    class P138
    {
        public RandomListNode CopyRandomList(RandomListNode head)
        {
            var dic = new Dictionary<RandomListNode, RandomListNode>();
            return GetOrAddRandomList(dic, head);
        }

        private RandomListNode GetOrAddRandomList(Dictionary<RandomListNode, RandomListNode> dic, RandomListNode node)
        {
            if (node == null) return null;

            if (dic.ContainsKey(node))
            {
                return dic[node];
            }
            else
            {
                var newNode = new RandomListNode(node.label);
                dic.Add(node, newNode);

                newNode.next = GetOrAddRandomList(dic, node.next);
                newNode.random = GetOrAddRandomList(dic, node.random);
                return newNode;
            }
        }
    }
}
