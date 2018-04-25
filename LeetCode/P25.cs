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

    public class P25
    {
        public ListNode ReverseKGroup(ListNode head, int k)
        {
            var stack = new Stack<ListNode>();
            var current = head;
            var result = head;
            ListNode pre = null;
            while (current != null)
            {
                for (int i = 0; i < k; i++)
                {
                    if (current != null)
                    {
                        stack.Push(current);
                        current = current.next;
                    }
                    else
                    {
                        return result;
                    }
                }

                for (int i = 0; i < k; i++)
                {
                    var node = stack.Pop();
                    if (pre != null)
                    {
                        pre.next = node;
                    }
                    else
                    {
                        result = node;
                    }
                    pre = node;
                }
                pre.next = current;
            }
            return result;
        }
    }
}
