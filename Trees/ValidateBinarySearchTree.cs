/*
Given the root of a binary tree, determine if it is a valid binary search tree (BST).

A valid BST is defined as follows:

The left 
subtree
 of a node contains only nodes with keys less than the node's key.
The right subtree of a node contains only nodes with keys greater than the node's key.
Both the left and right subtrees must also be binary search trees.

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
    public bool IsValidBST(TreeNode root) {
        List<int> sortedList = new List<int>();
        inorderTraverse(root, sortedList);

        for(int i=0; i < sortedList.Count() - 1; i++)
        {    
            if(sortedList[i] >= sortedList[i+1])
                return false;
        }

        return true;
    }

    public void inorderTraverse(TreeNode root, List<int> sortedList)
    {
        if(root != null)
        {
            inorderTraverse(root.left, sortedList);
            sortedList.Add(root.val);
            inorderTraverse(root.right, sortedList);
        }
    }
}