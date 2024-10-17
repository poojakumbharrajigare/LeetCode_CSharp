/*
You are given the root node of a binary search tree (BST) and a value to insert into the tree. 
Return the root node of the BST after the insertion. It is guaranteed that the new value does not exist in the original BST.

Notice that there may exist multiple valid ways for the insertion, as long as the tree remains a BST after insertion. 
You can return any of them.
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
    public TreeNode InsertIntoBST(TreeNode root, int val) {
        TreeNode newNode = new TreeNode(val);
        if(root == null)
            return newNode;
        
        TreeNode parent = null;
        TreeNode temp = root;

        while(temp != null)
        {
            parent = temp;
            if(val < temp.val)
                temp = temp.left;
            else
                temp = temp.right;
        }

        if(parent.val > val)
            parent.left = newNode;
        else
            parent.right = newNode;

        return root;
    }
}