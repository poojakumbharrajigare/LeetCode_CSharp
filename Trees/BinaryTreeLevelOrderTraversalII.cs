/*
Given the root of a binary tree, return the bottom-up level order traversal of its nodes' values. 
(i.e., from left to right, level by level from leaf to root).
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
    public IList<IList<int>> LevelOrderBottom(TreeNode root) {
        IList<IList<int>> result = new List<IList<int>>();
        Queue<TreeNode> q = new Queue<TreeNode>();

        if(root == null)
            return result;
        
        int level = 0;
        q.Enqueue(root);
        q.Enqueue(null);
        List<int> lst = new List<int>();

        while(q.Count > 1)
        {
            var x = q.Peek();
            q.Dequeue();
            if(x == null)
            {
                result.Insert(level, lst);
                lst = new List<int>();
                level++;
                q.Enqueue(null);
                continue;
            }
            else
            {
                lst.Add(x.val);
            }

            if(x.left != null)
                q.Enqueue(x.left);
            if(x.right != null)
                q.Enqueue(x.right);

        }

        result.Insert(level, lst);


        for(int i = 0; i <= level/2; i++)
        {
            var temp = result[i];
            result[i] = result[level - i];
            result[level - i] = temp;
        }

        return result;

    }
}