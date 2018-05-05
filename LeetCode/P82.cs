using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class P82
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null || head.next == null) return head;

            ListNode pre = null;
            ListNode current = head;
            ListNode next = current.next;
            ListNode result = null;
            ListNode left = null;

            while (current != null)
            {
                if ((pre == null || pre.val != current.val) && (next == null || next.val != current.val))
                {
                    if (left == null)
                    {
                        result = current;
                    }
                    else
                    {
                        left.next = current;
                    }
                    left = current;
                    left.next = null;
                }

                pre = current;
                current = next;
                if (next != null)
                {
                    next = next.next;
                }
            }

            return result;
        }
    }
}
