/*
Given the root of a binary tree, invert the tree, and return its root.
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
    public TreeNode InvertTree(TreeNode root) {
       /* if(root == null)
            return null;

        InvertTree(root.left);
        InvertTree(root.right);

        var temp = root.left;
        root.left = root.right;
        root.right = temp;

        return root;*/

        if(root == null) return null;
        Stack<TreeNode> st = new Stack<TreeNode>();
        st.Push(root);
        while(st.Count !=0)
        {
            TreeNode curr = st.Pop();
            Swap(curr);
            if(curr.right != null)
            {
                st.Push(curr.right);
            }
            if(curr.left != null)
            {
                st.Push(curr.left);
            }
        }
        return root;

        
    }
     void Swap(TreeNode node)
     {
        TreeNode tmp= node.left;
        node.left= node.right;
        node.right = tmp;
     }
}