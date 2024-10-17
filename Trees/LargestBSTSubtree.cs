/*
Given the root of a binary tree, find the largest subtree, which is also a Binary Search Tree (BST), where the largest means subtree has the largest number of nodes.

A Binary Search Tree (BST) is a tree in which all the nodes follow the below-mentioned properties:

The left subtree values are less than the value of their parent (root) node's value.
The right subtree values are greater than the value of their parent (root) node's value.
Note: A subtree must include all of its descendants.
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
    public int LargestBSTSubtree(TreeNode root) {
        if(root == null)
            return 0;
        
        if(IsBST(root, int.MinValue, int.MaxValue))
            return size(root);

        int x = LargestBSTSubtree(root.left);
        int y = LargestBSTSubtree(root.right);

        return Math.Max(x, y);
    }

    private bool IsBST(TreeNode root, int min, int max)
    {
        if(root == null)
            return true;
        
        if(root.val <= min || root.val >= max)
            return false;
        
        var left = IsBST(root.left, min, root.val);
        var right = IsBST(root.right, root.val, max);

        return left && right;
    }

    private int size(TreeNode root)
    {
        if(root == null) 
            return 0;

        int left = size(root.left);
        int right = size(root.right);

        return left + right + 1;
    }
}