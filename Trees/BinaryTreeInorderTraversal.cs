/*
Given the root of a binary tree, return the inorder traversal of its nodes' values.
*/
 * Definition for a binary tree node.
 * public class TreeNode {
 *     int val;
 *     TreeNode left;
 *     TreeNode right;
 *     TreeNode() {}
 *     TreeNode(int val) { this.val = val; }
 *     TreeNode(int val, TreeNode left, TreeNode right) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

class Solution {
    public List<int> inorderTraversal(TreeNode root) {
        List<int> result = new List<int>();
        inorderHelper(root, result);
        return result;
    }

    private void inorderHelper(TreeNode root, List<int> result) {
        if (root == null) 
        {
            return;
        }

        inorderHelper(root.left, result);
        result.Add(root.val);
        inorderHelper(root.right, result);
    }
}