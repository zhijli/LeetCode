using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class P86
    {
        public ListNode Partition(ListNode head, int x)
        {
            if (head == null || head.next == null) return head;

            ListNode left = null;
            ListNode pre = null;
            ListNode result = head;

            var current = head;

            while (current != null)
            {
                if (current.val < x)
                {
                    if (pre == null)
                    {
                        pre = current;
                        left = current;
                        result = current;
                    }
                    else if (left == null)
                    {
                        pre.next = current.next;
                        left = current;
                        result = current;
                        left.next = head;
                    }
                    else if (left == pre)
                    {
                        //corner case!
                        left = current;
                        pre = current;
                    }
                    else
                    {
                        pre.next = current.next;
                        current.next = left.next; ;
                        left.next = current;
                        left = current;
                    }

                    current = pre.next;
                }
                else
                {
                    pre = current;
                    current = current.next;
                }
            }

            return result;
        }
    }
}
