namespace LeetCode
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class P139
    {
        public bool WordBreak(string s, IList<string> wordDict)
        {
            var trie = BuildTrie(wordDict);
            var stack = new Stack<TrieNode>();
            stack.Push(trie);
            return WordBreak(s, 0, trie, trie, stack);
        }

        private bool WordBreak(string s, int v, TrieNode root, TrieNode current, Stack<TrieNode> stack)
        {
            if (current.isWord)
            {
                var find = WordBreak(s, v + 1, root, current, stack);

                if (current.Next.ContainsKey(s[v]))
                {
                    var find2 = WordBreak(s, v + 1, root, current, stack);
                }
            }
            else
            {

            }

            //if (current.Next.ContainsKey(s[v]))
            //{
            //    if (current.isWord)
            //    {
            //        var find = WordBreak(s, v + 1, root, root, stack);
            //    }
            //    else
            //    {

            //    }



            //}
            //else
            //{

            //}
        }

        private TrieNode BuildTrie(IList<string> wordDict)
        {
            var trie = new TrieNode();

            foreach (string word in wordDict)
            {
                var current = trie;
                foreach (char c in word)
                {
                    if (!current.Next.ContainsKey(c))
                    {
                        current.Next.Add(c, new TrieNode() { Key = c, Parrent = current });
                    }
                    current = current.Next[c];
                }
                current.isWord = true;
            }
            return trie;
        }
    }

    class TrieNode
    {
        public Dictionary<char, TrieNode> Next { get; set; } = new Dictionary<char, TrieNode>();
        public TrieNode Parrent { get; set; }
        public char? Key;
        public bool isWord { get; set; } = false;
    }


}
