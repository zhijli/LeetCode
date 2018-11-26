namespace LeetCode
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using LeetCode.Model;

    public class P133
    {
        public UndirectedGraphNode CloneGraph(UndirectedGraphNode node)
        {
            if (node == null) return null;

            var dic = new Dictionary<UndirectedGraphNode, UndirectedGraphNode>();
            var isVisited = new HashSet<UndirectedGraphNode>();
            var queue = new Queue<UndirectedGraphNode>();

            var result = GetOrAddGraphNodeMapping(dic, node);
            queue.Enqueue(node);
            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                if (!isVisited.Contains(current))
                {
                    var cloneNode = GetOrAddGraphNodeMapping(dic, current);

                    foreach (UndirectedGraphNode neighbor in current.neighbors)
                    {
                        var cloneNeighbor = GetOrAddGraphNodeMapping(dic, neighbor);
                        cloneNode.neighbors.Add(cloneNeighbor);
                        queue.Enqueue(neighbor);
                    }
                    isVisited.Add(current);
                }
            }

            return result;
        }

        private UndirectedGraphNode GetOrAddGraphNodeMapping(
            Dictionary<UndirectedGraphNode, UndirectedGraphNode> dic,
            UndirectedGraphNode node)
        {
            if (dic.ContainsKey(node))
            {
                return dic[node];
            }
            else
            {
                var newNode = new UndirectedGraphNode(node.label);
                dic.Add(node, newNode);
                return newNode;
            }
        }
    }
}
