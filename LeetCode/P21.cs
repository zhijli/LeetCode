using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class P21
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null)
            {
                return l2;
            }
            if (l2 == null)
            {
                return l1;
            }

            var p1 = l1;
            var p2 = l2;
            ListNode head;
            ListNode current = null;

            if (l1.val > l2.val)
            {
                head = l2;
            }
            else
            {
                head = l1;
            }

            while (p1 != null && p2 != null)
            {
                if (p1.val > p2.val)
                {
                    if (current != null)
                    {
                        current.next = p2;
                        current = current.next;
                    }
                    else
                    {
                        current = p2;
                    }
                    p2 = p2.next;
                }
                else
                {
                    if (current != null)
                    {
                        current.next = p1;
                        current = current.next;
                    }
                    else
                    {
                        current = p1;
                    }
                    p1 = p1.next;
                }
            }

            if (p1 == null)
            {
                current.next = p2;
            }
            else
            {
                current.next = p1;
            }
            return head;
        }
    }
}
