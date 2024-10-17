/*
Given the head of a linked list, return the node where the cycle begins. If there is no cycle, return null.

There is a cycle in a linked list if there is some node in the list that can be reached again by continuously following the next pointer. 
Internally, pos is used to denote the index of the node that tail's next pointer is connected to (0-indexed). It is -1 if there is no cycle. 
Note that pos is not passed as a parameter.

Do not modify the linked list.
*/

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public ListNode DetectCycle(ListNode head) {
        //Base condition imp
        if(head == null || head.next == null || head.next.next == null)
            return null;

        ListNode slow = head;
        ListNode fast = head;

        while(fast.next != null && fast.next.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
            //imp
            if(slow == fast)
                break;
        }


        if(slow == fast && slow != null && fast != null)
        {
            // slow has started from head and fast is started from meeting point
            slow = head;
            while(slow != fast)
            {
                //slow and fast are moving with same speed.
                slow = slow.next;
                fast = fast.next;
            }

            return slow;
        }
        else
        {
            return null;
        }
    }
}