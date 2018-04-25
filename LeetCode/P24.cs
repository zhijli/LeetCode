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

    class P24
    {
        public ListNode SwapPairs(ListNode head)
        {
            if (head == null || head.next == null) return head;

            var current = head;
            var result = head.next;
            ListNode pre = null;

            while (current != null && current.next != null)
            {
                var next = current.next;
                current.next = next.next;
                if (pre != null)
                {
                    pre.next = next;
                }
                next.next = current;
                pre = current;
                current = current.next;
            }

            return result;
        }
    }
}
