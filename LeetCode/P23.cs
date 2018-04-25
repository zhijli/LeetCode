// -----------------------------------------------------------------------
//  <copyright company="Microsoft">
//      Copyright (c) Microsoft Corporation.  All rights reserved.
//  </copyright>
// -----------------------------------------------------------------------

namespace LeetCode
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class P23
    {
        public ListNode MergeKLists(ListNode[] lists)
        {
            if (lists == null || lists.Length == 0) return null;
            var result = lists[0];
            for (int i = 1; i < lists.Length; i++)
            {
                result = MergeTwoLists(result, lists[i]);
            }

            return result;
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
