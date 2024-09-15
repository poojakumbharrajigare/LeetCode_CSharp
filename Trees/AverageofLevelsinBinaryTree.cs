/*
Given the root of a binary tree, return the average value of the nodes on each level in the form of an array. 
Answers within 10-5 of the actual answer will be accepted.
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
    public IList<double> AverageOfLevels(TreeNode root) {
        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(root);
        List<double> result = new List<double>();

        while(q.Count() > 0)
        {
            double qLength = q.Count();
            double sum = 0;

            for(int i = 0; i < qLength; i++)
            {
                TreeNode current = q.Dequeue();
                sum += current.val;

                if(current.left != null)
                    q.Enqueue(current.left);
                if(current.right != null)
                    q.Enqueue(current.right);
            }

            result.Add(sum / qLength);
        }

        return result;
    }
}