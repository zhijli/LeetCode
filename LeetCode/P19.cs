using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class P19
    {
        public class Solution
        {

            public class ListNode
            {
                public int val;
                public ListNode next;
                public ListNode(int x) { val = x; }
            }


            public ListNode RemoveNthFromEnd(ListNode head, int n)
            {
                if (head == null) return null;
                if (n == 0) return head;

                ListNode current, nextN;
                current = nextN = head;
                while (nextN.next != null && n > 0)
                {
                    nextN = nextN.next;
                    n--;
                }

                if (n == 1)
                {
                   return head.next;
                }

                while (nextN.next != null)
                {
                    nextN = nextN.next;
                    current = current.next;
                }

                current.next = current.next.next;
                return head;
            }
        }
    }
}