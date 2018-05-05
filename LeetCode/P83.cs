using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class P83
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null || head.next == null) return head;

            var current = head;
            var next = head.next;

            while (current != null)
            {
                while (next != null && current.val == next.val)
                {
                    next = next.next;
                }

                current.next = next;
                current = next;
            }

            return head;
        }
    }
}
