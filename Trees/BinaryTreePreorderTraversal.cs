/*
Given the root of a binary tree, return the preorder traversal of its nodes' values.
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
    public IList<int> PreorderTraversal(TreeNode root) {
        IList<int> result = new List<int>();
        preorderHelper(root, result);

        return result;
    }

    private void preorderHelper(TreeNode root, IList<int> result)
    {
        if(root == null)
            return;

        result.Add(root.val);
        preorderHelper(root.left, result);
        preorderHelper(root.right, result);
    }
}