/*
Given the head of a linked list, find all the values that appear more than once in the list and delete the nodes that have any of those values.

Return the linked list after the deletions.
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
    public ListNode DeleteDuplicatesUnsorted(ListNode head) {

        Dictionary<int, int> map = new Dictionary<int, int>();

        //need to create dummy extra node just like a head node.. do not use
        ListNode dummy = new ListNode(-1, head);
        ListNode pre = dummy;
        ListNode current = head;

        while(current !=null)
        {
            if(map.ContainsKey(current.val))
            {
                map[current.val]++;
            }
            else
            {
                map.Add(current.val, 1);
            }

            current = current.next;
        }

        current = head;
        while(current !=null)
        {
            if(map[current.val] > 1)
            {
                pre.next = current.next;
                current = pre.next;
            }
            else
            {
                pre = current;
                current = current.next;
            }
        }

        return dummy.next;
    }
}