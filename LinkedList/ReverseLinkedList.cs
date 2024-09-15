/*
Given the head of a singly linked list, reverse the list, and return the reversed list.
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
    public ListNode ReverseList(ListNode head) {
        ListNode current = head;
        ListNode pre = null;

        while (current != null)
        {
            ListNode next = current.next;
            current.next = pre;
            pre = current;
            current = next;
        }

        head = pre;

        return head;    
    }
}