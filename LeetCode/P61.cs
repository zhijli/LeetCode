using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class P61
    {
        public ListNode RotateRight(ListNode head, int k)
        {
            if (head == null) return head;

            var current = head;
            var count = 0;
            ListNode tail = null;
            while (current != null)
            {
                tail = current;
                current = current.next;
                count++;
            }

            var val = k % count;
            if (val == 0)
            {
                return head;
            }

            int t = count - val;

            current = head;
            for (; t > 1; t--)
            {
                current = current.next;
            }

            var result = current.next; 
            tail.next = head;
            current.next = null;
            return result;
        }
    }
}
