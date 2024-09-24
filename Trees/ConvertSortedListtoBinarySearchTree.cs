/*
Given the head of a singly linked list where elements are sorted in ascending order, convert it to a 
height-balanced binary search tree.
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
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public TreeNode SortedListToBST(ListNode head) {
        if (head == null) 
        {
            return null;
        }

        return toBST(head, null);
    }

    private TreeNode toBST(ListNode head, ListNode tail) {
        if (head == tail) 
        {
            return null;
        }

        ListNode mid = findMid(head, tail);
        TreeNode node = new TreeNode(mid.val);
        node.left = toBST(head, mid);
        node.right = toBST(mid.next, tail);

        return node;
    }

    private ListNode findMid(ListNode head, ListNode tail)
    {
        ListNode slow = head;
        ListNode fast = head;

        while (fast != tail && fast.next != tail) 
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        return slow;
    }
}