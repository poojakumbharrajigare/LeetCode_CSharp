/*
Given the head of a sorted linked list, delete all nodes that have duplicate numbers, 
leaving only distinct numbers from the original list. Return the linked list sorted as well.
*/

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode DeleteDuplicates(ListNode head) {
        var dummyHead = new ListNode(-1, head);
        var prev = dummyHead;
        var current = dummyHead.next;

        while (current != null && current.next != null) 
        {
            if(current.val == current.next.val)
            {
                while(current.next != null && current.val == current.next.val)
                {
                    current = current.next;
                }

                prev.next = current.next;
                current = prev.next;
            }
            else
            {
                prev = current;
                current = current.next;
            }
        }

        return dummyHead.next;
    }
}