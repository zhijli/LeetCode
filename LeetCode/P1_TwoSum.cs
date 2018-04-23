using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    using System.Collections;

    public class P2_AddTwoNumbers
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode result = null;
            ListNode current = null;
            int inc = 0;
            var sum = 0;

            while (l1 != null && l2 != null)
            {
                sum = l1.val + l2.val + inc;
                if (sum >= 10)
                {
                    sum -= 10;
                    inc = 1;
                }
                else
                {
                    inc = 0;
                }

                if (result == null)
                {
                    result = current = new ListNode(sum);
                }
                else
                {
                    current.next = new ListNode(sum);
                    current = current.next;
                }

                l1 = l1.next;
                l2 = l2.next;
            }

            while (l1 != null)
            {
                sum = l1.val + inc;
                if (sum >= 10)
                {
                    sum -= 10;
                    inc = 1;
                }
                else
                {
                    inc = 0;
                }

                current.next = new ListNode(sum);
                current = current.next;
                l1 = l1.next;
            }

            while (l2 != null)
            {
                sum = l2.val + inc;
                if (sum >= 10)
                {
                    sum -= 10;
                    inc = 1;
                }
                else
                {
                    inc = 0;
                }

                current.next = new ListNode(sum);
                current = current.next;
                l2 = l2.next;
            }

            if (inc == 1)
            {
                current.next = new ListNode(inc);
            }

            return result;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

}
