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

    public class P92
    {
        public ListNode ReverseBetween(ListNode head, int m, int n)
        {
            if (head == null || m == n) return head;

            var current = head;
            var mNode = head;
            var nNode = head;
            ListNode mNodePre = null;
            ListNode nNodeNext = null;
            while (n > 1)
            {
                if (m == 2) mNodePre = current;
                if (m == 1) mNode = current;
                current = current.next;
                n--;
                m--;
            }
            nNode = current;

            if (mNodePre == null)
            {
                head = nNode;
            }
            else
            {
                mNodePre.next = nNode;
            }

            var pre = mNode;
            current = mNode.next;
            mNode.next = nNode.next;
            while (current != nNode)
            {
                var next = current.next;
                current.next = pre;
                pre = current;
                current = next;
            }
            current.next = pre;

            return head;
        }
    }
}
