/*
You are given two non-empty linked lists representing two non-negative integers. 
The digits are stored in reverse order, and each of their nodes contains a single digit. Add the two numbers and return the sum as a linked list.

You may assume the two numbers do not contain any leading zero, except the number 0 itself.
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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode newNode = new ListNode(-1);
        ListNode temp = newNode;

        if(l1 == null && l2 == null) 
            return null;
        
        int carry = 0;
        while(l1 != null || l2 != null || carry != 0)
        {
	        int total = (l1 != null ? l1.val : 0) + (l2 != null ? l2.val : 0) + carry;
	        carry = total / 10;
	        int val = total % 10;
            temp.next = new ListNode(val);
            temp = temp.next;
            l1 = l1?.next;
            l2 = l2?.next;
        }

        return newNode.next;
    }
}