/*
Given the root of a binary tree, check whether it is a mirror of itself (i.e., symmetric around its center).
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
    public bool IsSymmetric(TreeNode root) {
        if(root == null)
            return true;
        
        return checkSymmetry(root.left, root.right);
    }

    private bool checkSymmetry(TreeNode leftRoot, TreeNode rightRoot)
    {
        if(leftRoot == null && rightRoot == null)
            return true;

        if(leftRoot == null || rightRoot == null)
            return false;

        return leftRoot.val == rightRoot.val && checkSymmetry(leftRoot.left, rightRoot.right) && checkSymmetry(leftRoot.right, rightRoot.left);
    }
}