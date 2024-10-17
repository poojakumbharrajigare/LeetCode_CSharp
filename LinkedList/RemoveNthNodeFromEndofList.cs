/*
Given the head of a linked list, remove the nth node from the end of the list and return its head.
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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        ListNode previousNode = null;
        var next = head;
        var i = 0;
        
        while(next != null)
        {
            next = next.next;
            // move head (totalLength - n) from head;
            if(i == n)
            {
                previousNode = head;
            }
            else if(i > n)
            {
                previousNode = previousNode.next;
            }
            i++;
        }

        // no previous node means we must remove the first element in the list
        if(previousNode == null)
        {
            head = head?.next;
        }
        else if(previousNode.next != null)
        {
            // exclude element to be removed from the list
            previousNode.next = previousNode.next.next;
        }

        return head;
    }
}